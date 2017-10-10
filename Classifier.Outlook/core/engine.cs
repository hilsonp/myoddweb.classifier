﻿using System;
using System.Collections.Generic;
using Classifier.Interfaces;
using myoddweb.classifier.utils;
using System.Linq;
using Classifier.Interfaces.Helpers;
using System.Timers;
using Newtonsoft.Json;
using myoddweb.classifier.interfaces;

namespace myoddweb.classifier.core
{
  public class Engine : IEngine
  {
    /// <summary>
    /// If NULL we have not check for event source.
    /// Any other value, we will check for.
    /// </summary>
    private bool? _eventSource = null;

    /// <summary>
    /// Name for logging in the event viewer,
    /// </summary>
    private readonly string EventViewSource;

    /// <summary>
    /// All the options
    /// </summary>
    private Options _options;

    /// <summary>
    /// all the categories.
    /// </summary>
    private Categories _categories;

    /// <summary>
    /// Public accessor of the options.
    /// </summary>
    public Options Options => _options ?? (_options = new Options(this));

    public Categories Categories => _categories ?? (_categories = new Categories(this));

    /// <summary>
    /// The classification engine.
    /// </summary>
    public IClassify1 ClassifyEngine { get; private set; }

    private Microsoft.Office.Interop.Outlook.MAPIFolder _rootFolder;

    /// <summary>
    /// The timer we use to call the clean log function.
    /// </summary>
    Timer LogTimer { get; set; }

    /// <summary>
    /// The engine constructor.
    /// </summary>
    /// <param name="classifyEngine">The classification engine</param>
    /// <param name="eventViewSource">The event log name.</param>
    public Engine( IClassify1 classifyEngine, string eventViewSource )
    {
      // save the classify engine.
      ClassifyEngine = classifyEngine;

      // start the 'cleanup' timer.
      StartLogCleanupTimer();

      // set the event view source.
      EventViewSource = eventViewSource;
    }

    ~Engine()
    {
      // release the engine
      ReleaseEngine();

      // stop the log
      StopLogCleanupTimer();
    }

          // start the 'cleanup' timer.
    private void StartLogCleanupTimer()
    {
      //  stop the timer if need be.
      StopLogCleanupTimer();

      // start the new time
      LogTimer = new Timer();
      LogTimer.Elapsed += OnTimedLogEvent;
      LogTimer.Interval = 60 * 60 * 1000;  // one hour
      LogTimer.Enabled = true;
    }

    private void StopLogCleanupTimer()
    {
      LogTimer?.Stop();
      LogTimer?.Dispose();
      LogTimer = null;
    }

    private void OnTimedLogEvent(object source, ElapsedEventArgs e)
    {
      if( null == ClassifyEngine )
      {
        return;
      }

      // days of retention
      var daysRetention = Options.LogRetention;

      // the oldest log date
      var date = DateTime.UtcNow.AddDays(daysRetention * -1);

      // delete old entries.
      ClassifyEngine.ClearLogEntries(Helpers.DateTimeToUnix(date));
    }

    public void Release()
    {
      // stop the time
      StopLogCleanupTimer();

      // release the engine
      ReleaseEngine();
    }

    /// <summary>
    /// Release the engine and do all the cleanup needed.
    /// Normally closed when the app is closing down.
    /// </summary>
    private void ReleaseEngine()
    {
      //  do we have an engine to release?
      if (null == ClassifyEngine)
      {
        return;
      }

      // release it then.
      ClassifyEngine.Release();

      // and free the memory
      ClassifyEngine = null;
    }

    private bool InstallAndValidateSource()
    {
      if (null != _eventSource)
      {
        return (bool) _eventSource;
      }

      try
      {
        if (!System.Diagnostics.EventLog.SourceExists(EventViewSource))
        {
          System.Diagnostics.EventLog.CreateEventSource(EventViewSource, null);
        }

        // set the value.
        _eventSource = System.Diagnostics.EventLog.SourceExists(EventViewSource);
      }
      catch (System.Security.SecurityException)
      {
        _eventSource = false;
      }

      // one last check.
      return InstallAndValidateSource();
    }

    /// <summary>
    /// Log a message to the engine
    /// </summary>
    /// <param name="message"></param>
    /// <param name="level"></param>
    private void LogMessageToEngine( string message, Options.LogLevels level )
    {
      // can we log this?
      if (!Options.CanLog(level))
      {
        return;
      }

      //  create the json string.
      var lm = new LogData { Level = level, Message = message };
      string json = JsonConvert.SerializeObject(lm, Formatting.None);

      // log the string now.
      ClassifyEngine.Log(LogSource(level), json);
    }

    /// <summary>
    /// Log a verbose message
    /// </summary>
    /// <param name="message"></param>
    public void LogVerbose(string message)
    {
      // log it
      LogMessageToEngine(message, Options.LogLevels.Verbose);

      // log to the event log.
      if (!InstallAndValidateSource())
      {
        return;
      }

      var appLog = new System.Diagnostics.EventLog { Source = EventViewSource };
      appLog.WriteEntry(message, System.Diagnostics.EventLogEntryType.Information );
    }

    /// <summary>
    /// Log an error message
    /// </summary>
    /// <param name="message"></param>
    public void LogError(string message)
    {
      // log it
      LogMessageToEngine(message, Options.LogLevels.Error);

      // log to the event log.
      if (!InstallAndValidateSource())
      {
        return;
      }

      var appLog = new System.Diagnostics.EventLog { Source = EventViewSource };
      appLog.WriteEntry(message, System.Diagnostics.EventLogEntryType.Error);
    }

    /// <summary>
    /// Log a warning message
    /// </summary>
    /// <param name="message"></param>
    public void LogWarning(string message)
    {
      // log it
      LogMessageToEngine(message, Options.LogLevels.Warning);

      // log to the event log.
      if (!InstallAndValidateSource())
      {
        return;
      }

      var appLog = new System.Diagnostics.EventLog { Source = EventViewSource };
      appLog.WriteEntry(message, System.Diagnostics.EventLogEntryType.Warning);
    }

    /// <summary>
    /// Log an information message
    /// </summary>
    /// <param name="message"></param>
    public void LogInformation(string message)
    {
      // log it
      LogMessageToEngine(message, Options.LogLevels.Information);

      // log to the event log.
      if (!InstallAndValidateSource())
      {
        return;
      }

      var appLog = new System.Diagnostics.EventLog { Source = EventViewSource };
      appLog.WriteEntry(message, System.Diagnostics.EventLogEntryType.Information);
    }

    /// <summary>
    /// Get up to 'max' log entries.
    /// </summary>
    /// <param name="max">The max number of log entries we want to get.</param>
    /// <returns></returns>
    public List<LogEntry> GetLogEntries( int max )
    {
      // get the log entries,
      List<LogEntry> entries;
      return -1 == ClassifyEngine.GetLogEntries(out entries, max ) ? null : entries;
    }

    /// <summary>
    /// Get the current version number of the engine.
    /// </summary>
    /// <returns>int the engine version number</returns>
    public int GetEngineVersionNumber()
    {
      return ClassifyEngine.GetEngineVersion();
    }

    /// <summary>
    /// Get the current version number of the engine.
    /// </summary>
    /// <returns>Version the engine version number</returns>
    public Version GetEngineVersion()
    {
      //  get the version
      var engineVersion = GetEngineVersionNumber();
      var major = (int)(engineVersion / 1000000.0);

      engineVersion -= (major * 1000000);
      var minor = (int)(engineVersion / 1000.0);

      engineVersion -= (minor * 1000);
      var build = engineVersion;
      return new Version( major, minor, build, 0 );
    }

    public string GetConfig(string configName )
    {
      string configValue;
      if (!ClassifyEngine.GetConfig(configName, out configValue))
      {
        throw new KeyNotFoundException("The value could not be found!");
      }
      return configValue;
    }

    /// <summary>
    /// Same as GetConfig( ... ) but if the value does not exist we will return the default.
    /// </summary>
    /// <param name="configName"></param>
    /// <param name="defaultValue"></param>
    /// <returns></returns>
    public string GetConfigWithDefault(string configName, string defaultValue )
    {
      try
      {
        return GetConfig(configName);
      }
      catch (KeyNotFoundException)
      {
        return defaultValue;
      }
    }

    public bool SetConfig(string configName, string configValue)
    {
      return ClassifyEngine?.SetConfig(configName, configValue) ?? false;
    }

    public bool Train(string categoryName, string textToCategorise, string uniqueIdentifier, int weight )
    {
      if (weight <= 0)
      {
        throw new ArgumentException( "The weight cannot be 0 or less!" );
      }
      return ClassifyEngine?.Train(categoryName, textToCategorise, uniqueIdentifier, weight ) ?? false;
    }

    public bool UnTrain( string uniqueIdentifier, string textToCategorise)
    {
      return ClassifyEngine?.UnTrain( uniqueIdentifier, textToCategorise) ?? false;
    }

    public int GetCategory(string categoryName)
    {
      return ClassifyEngine?.GetCategory(categoryName ) ?? -1;
    }

    public int GetCategoryFromUniqueId(string uniqueIdentifier)
    {
      return ClassifyEngine?.GetCategoryFromUniqueId( uniqueIdentifier ) ?? -1;
    }

    public int Categorize(string categoryText, uint minPercentage, out List<WordCategory> wordsCategory, out Dictionary<int, double > categoryProbabilities)
    {
      wordsCategory = new List<WordCategory>();
      categoryProbabilities = new Dictionary<int, double>();

      // the category min percentage cannot be more than 100%.
      // it also cannot be less than 0, but we use a uint.
      if (minPercentage > 100)
      {
        throw new ArgumentException("The categotry minimum range cannot be more than 100%.");
      }
      return ClassifyEngine?.Categorize(categoryText, minPercentage, out wordsCategory, out categoryProbabilities ) ?? -1;
    }

    public int Categorize(string categoryText, uint minPercentage )
    {
      // the category min percentage cannot be more than 100%.
      // it also cannot be less than 0, but we use a uint.
      if (minPercentage > 100)
      {
        throw new ArgumentException("The categotry minimum range cannot be more than 100%.");
      }

      return ClassifyEngine?.Categorize(categoryText, minPercentage) ?? -1;
    }

    public int Categorize(Dictionary< Categories.MailStringCategories, string> categoryList)
    {
      return Categorize(string.Join(";", categoryList.Select(x => x.Value) ), Options.MinPercentage );
    }

    public Dictionary<int, string> GetCategories( )
    {
      var categories = new Dictionary<int, string>();
      if (ClassifyEngine?.GetCategories(out categories) < 0 )
      {
        return new Dictionary<int, string>();
      }
      return categories;
    }

    public bool RenameCategory(string oldCategory, string newCategory)
    {
      return ClassifyEngine?.RenameCategory(oldCategory, newCategory) ?? false;
    }

    public bool DeleteCategory(string categoryName)
    {
      return ClassifyEngine.DeleteCategory(categoryName);
    }

    public void SetRootFolder(Microsoft.Office.Interop.Outlook.MAPIFolder rootFolder)
    {
      // set the root folder.
      _rootFolder = rootFolder;
    }

    public Microsoft.Office.Interop.Outlook.MAPIFolder GetRootFolder()
    {
      return _rootFolder;
    }

    /// <summary>
    /// Create a magnet.
    /// </summary>
    /// <param name="randomName"></param>
    /// <param name="ruleType"></param>
    /// <param name="categoryId"></param>
    /// <returns></returns>
    public int CreateMagnet(string randomName, int ruleType, int categoryId)
    {
      return ClassifyEngine.CreateMagnet(randomName, ruleType, categoryId );
    }

    /// <summary>
    /// Delete a magnet given a magnet id.
    /// </summary>
    /// <param name="magnetId"></param>
    /// <returns></returns>
    public bool DeleteMagnet(int magnetId)
    {
      return ClassifyEngine.DeleteMagnet(magnetId);
    }

    /// <summary>
    /// Update a magnet
    /// </summary>
    /// <param name="magnetId">The magnet id</param>
    /// <param name="magnetName">The magnet name</param>
    /// <param name="ruleType">The rule type we are updating to</param>
    /// <param name="categoryTarget">The target category when the rule is matched.</param>
    /// <returns></returns>
    public bool UpdateMagnet(int magnetId, string magnetName, int ruleType, int categoryTarget )
    {
      return ClassifyEngine.UpdateMagnet(magnetId, magnetName, ruleType, categoryTarget );
    }

    /// <summary>
    /// Update an existing magnet
    /// We only update it if the values do not match exactly.
    /// </summary>
    /// <param name="currentMagnet">The current magnet we might update</param>
    /// <param name="magnetName">The updated name</param>
    /// <param name="ruleType">The updated rule type</param>
    /// <param name="categoryTarget">the updated category target.</param>
    /// <returns>boolean success or not.</returns>
    public bool UpdateMagnet(Magnet currentMagnet, string magnetName, int ruleType, int categoryTarget)
    {
      // sanity check does the value exist?
      if( null == currentMagnet )
      {
        return false;
      }

      // does it already match what we have?
      if (currentMagnet.Category == categoryTarget && currentMagnet.Rule == ruleType && currentMagnet.Name == magnetName )
      {
        //  nothing to do.
        return true;
      }

      // looks like we might do an update, do it now.
      return UpdateMagnet(currentMagnet.Id, magnetName, ruleType, categoryTarget);
    }

    /// <summary>
    /// Get our complete list of magnets.
    /// </summary>
    /// <returns>List of magnets or null</returns>
    public List<Magnet> GetMagnets()
    {
      List<Magnet> magnets;
      return -1 == ClassifyEngine.GetMagnets(out magnets) ? null : magnets;
    }

    private static string LogSource( Options.LogLevels level )
    {
      return $"{System.Diagnostics.Process.GetCurrentProcess().ProcessName}.{level}";
    }
  }
}
