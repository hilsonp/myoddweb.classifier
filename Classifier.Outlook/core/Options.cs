﻿using myoddweb.classifier.interfaces;
using System;

namespace myoddweb.classifier.core
{
  public sealed class Options : IOptions
  {
    /// <summary>
    /// The configuration insterface.
    /// </summary>
    private readonly IConfig _config;

    private bool? _reAutomaticallyTrainMagnetMessages;

    private bool? _reAutomaticallyTrainMessages;

    private bool? _reCheckCategories;

    private bool? _checkIfUnknownCategory;

    private bool? _checkUnProcessedEmailsOnStartUp;

    private bool? _reCheckIfCtrlIsDown;

    private uint? _magnetsWeight;

    private uint? _userWeight;

    private LogLevels? _logLevel;

    private uint? _logRetention;

    private uint? _logDisplaySize;

    private uint? _commonWordsMinPercent;

    private uint? _minPercentage;

    private uint? _classifyDelaySeconds;

    private bool? _reAutomaticallyTrainMoveMessages;

    private bool? _reConfirmMultipleTainingCategory;

    private uint? _numberOfItemsToParse;

    /// <summary>
    /// (re) Check all the categories all the time.
    /// This is on by default as we have the other default option "CheckIfUnKnownCategory" also set to on.
    /// The net effect of that would be to only check if we don't already know the value.
    /// </summary>
    public uint MinPercentage
    {
      get =>
        (uint)(_minPercentage ??
               (_minPercentage = (Convert.ToUInt32(_config.GetConfigWithDefault("Option.MinPercentage", Convert.ToString((uint)DefaultOptions.MinPercentage))))));
      set
      {
        _minPercentage = value;
        _config.SetConfig("Option.MinPercentage", Convert.ToString(value));
      }
    }

    /// <summary>
    /// The number of seconds we want to wait before we classify a message.
    /// This delay is needed to let outlook apply its own rules.
    /// </summary>
    public uint ClassifyDelaySeconds
    {
      get =>
        (uint)(_classifyDelaySeconds ??
               (_classifyDelaySeconds = (Convert.ToUInt32(_config.GetConfigWithDefault("Option.ClassifyDelaySeconds", "1")))));
      set
      {
        _classifyDelaySeconds = value;
        _config.SetConfig("Option.ClassifyDelaySeconds", Convert.ToString(value));
      }
    }

    /// <summary>
    /// Get the classification delay in milliseconds.
    /// </summary>
    public uint ClassifyDelayMilliseconds => (ClassifyDelaySeconds*1000);

    /// <summary>
    /// (re) Check all the categories all the time.
    /// This is on by default as we have the other default option "CheckIfUnKnownCategory" also set to on.
    /// The net effect of that would be to only check if we don't already know the value.
    /// </summary>
    public bool ReCheckCategories
    {
      get =>
        (bool) (_reCheckCategories ??
                (_reCheckCategories = ("1" == _config.GetConfigWithDefault("Option.ReCheckCategories", "1"))));
      set
      {
        _reCheckCategories = value;
        _config.SetConfig("Option.ReCheckCategories", (value ? "1" : "0") );
      }
    }

    /// <summary>
    /// Check if we want to train the message because we used a magnet.
    /// </summary>
    public bool ReAutomaticallyTrainMagnetMessages
    {
      get =>
        (bool)(_reAutomaticallyTrainMagnetMessages ??
               (_reAutomaticallyTrainMagnetMessages = ("1" == _config.GetConfigWithDefault("Option.ReAutomaticallyTrainMagnetMessages", "1"))));
      set
      {
        _reAutomaticallyTrainMagnetMessages = value;
        _config.SetConfig("Option.ReAutomaticallyTrainMagnetMessages", (value ? "1" : "0"));
      }
    }

    /// <inheritdoc />
    /// <summary>
    /// Check if we want to train the message because we moved it from one folder to another
    /// Assuming that the folder we moved it to has a category we can train to.
    /// </summary>
    public bool ReAutomaticallyTrainMoveMessages
    {
      get =>
        (bool)(_reAutomaticallyTrainMoveMessages ??
               (_reAutomaticallyTrainMoveMessages = ("1" == _config.GetConfigWithDefault("Option.ReAutomaticallyTrainMoveMessages", "1"))));
      set
      {
        _reAutomaticallyTrainMoveMessages = value;
        _config.SetConfig("Option.ReAutomaticallyTrainMoveMessages", (value ? "1" : "0"));
      }
    }

    /// <inheritdoc />
    /// <summary>
    /// When we have more than one category to choose from, do we want to ask the user
    /// To choose a category or do we assume that they picked nothing.
    /// This is if the user does not want a dialog box to appear all the time.
    /// </summary>
    public bool ReConfirmMultipleTainingCategory
    {
      get =>
        (bool)(_reConfirmMultipleTainingCategory ??
               (_reConfirmMultipleTainingCategory = ("1" == _config.GetConfigWithDefault("Option.ReConfirmMultipleTainingCategory", "1"))));
      set
      {
        _reConfirmMultipleTainingCategory = value;
        _config.SetConfig("Option.ReConfirmMultipleTainingCategory", (value ? "1" : "0"));
      }
    }

    /// <summary>
    /// Check if we want to automaticlly train messages when they arrive.
    /// We categorise messages, but do we also want to train them?
    /// By default we don't do that...
    /// </summary>
    public bool ReAutomaticallyTrainMessages
    {
      get =>
        (bool)(_reAutomaticallyTrainMessages ??
               (_reAutomaticallyTrainMessages = ("1" == _config.GetConfigWithDefault("Option.ReAutomaticallyTrainMessages", "0"))));
      set
      {
        _reAutomaticallyTrainMessages = value;
        _config.SetConfig("Option.ReAutomaticallyTrainMessages", (value ? "1" : "0"));
      }
    }

    /// <summary>
    /// (re) Check all the categories if the control key is pressed down.
    /// This is on by default as the control key has to be pressed.
    /// </summary>
    public bool ReCheckIfCtrlKeyIsDown
    {
      get =>
        (bool)(_reCheckIfCtrlIsDown ??
               (_reCheckIfCtrlIsDown = ("1" == _config.GetConfigWithDefault("Option.ReCheckIfCtrlKeyIsDown", "1"))));
      set
      {
        _reCheckIfCtrlIsDown = value;
        _config.SetConfig("Option.ReCheckIfCtrlKeyIsDown", (value ? "1" : "0"));
      }
    }

    /// <summary>
    /// Set the magnet weight multiplier.
    /// </summary>
    public uint MagnetsWeight
    {
      get =>
        (uint)(_magnetsWeight ??
               (_magnetsWeight = (Convert.ToUInt32(_config.GetConfigWithDefault("Option.MagnetsWeight", Convert.ToString( (uint)DefaultOptions.MagnetsWeight))))));
      set
      {
        _magnetsWeight = value;
        _config.SetConfig("Option.MagnetsWeight", Convert.ToString(value));
      }
    }

    /// <summary>
    /// Set the user weight multiplier.
    /// </summary>
    public uint UserWeight
    {
      get =>
        (uint)(_userWeight ??
               (_userWeight = (Convert.ToUInt32(_config.GetConfigWithDefault("Option.UserWeight", Convert.ToString( (uint)DefaultOptions.UserWeight))))));
      set
      {
        _userWeight = value;
        _config.SetConfig("Option.UserWeight", Convert.ToString(value));
      }
    }

    /// <summary>
    /// Get or set the log retention policy
    /// </summary>
    public uint LogRetention
    {
      get =>
        (uint)(_logRetention ??
               (_logRetention = Convert.ToUInt32(_config.GetConfigWithDefault("Option.LogRetention", Convert.ToString((uint)DefaultOptions.LogRetention)))));
      set
      {
        _logRetention = value;
        _config.SetConfig("Option.LogRetention", Convert.ToString(value));
      }
    }

    /// <summary>
    /// Get the number of log entries we want to display
    /// </summary>
    public uint LogDisplaySize
    {
      get =>
        (uint)( _logDisplaySize ??
                (_logDisplaySize = Convert.ToUInt32(_config.GetConfigWithDefault("Option.LogDisplaySize", Convert.ToString((uint)DefaultOptions.LogDisplaySize)))));
      set
      {
        _logDisplaySize = value;
        _config.SetConfig("Option.LogDisplaySize", Convert.ToString(value));
      }
    }

    /// <summary>
    /// Get or set the log level
    /// </summary>
    public LogLevels LogLevel
    {
      get =>
        (LogLevels)(_logLevel ??
                    (_logLevel = (LogLevels)(int.Parse(_config.GetConfigWithDefault("Option.LogLevels", $"{(uint)DefaultOptions.LogLevel}")))));
      set
      {
        _logLevel = value;
        _config.SetConfig("Option.LogLevels", Convert.ToString( (int)value));
      }
    }

    /// <summary>
    /// Mainly used for exchange, when outlook starts we want to check unprocessed emails.
    /// In some cases emails are 'received' even if outlook is not running.
    /// </summary>
    public bool CheckUnProcessedEmailsOnStartUp
    {
      get =>
        (bool)(_checkUnProcessedEmailsOnStartUp ??
               (_checkUnProcessedEmailsOnStartUp = ("1" == _config.GetConfigWithDefault("Option.CheckUnProcessedEmailsOnStartUp", "1"))));
      set
      {
        _checkUnProcessedEmailsOnStartUp = value;
        _config.SetConfig("Option.CheckUnProcessedEmailsOnStartUp", (value ? "1" : "0"));
      }
    }

    /// <summary>
    /// Check the category only if we don't currently have a valid value.
    /// The default is to get the value if the value is not known.
    /// </summary>
    public bool CheckIfUnKnownCategory
    {
      get =>
        (bool)(_checkIfUnknownCategory ??
               (_checkIfUnknownCategory = ("1" == _config.GetConfigWithDefault("Option.CheckIfUnKnownCategory", "1"))));
      set
      {
        _checkIfUnknownCategory = value;
        _config.SetConfig("Option.CheckIfUnKnownCategory", (value ? "1" : "0"));
      }
    }

    public uint CommonWordsMinPercent
    {
      get =>
        (uint)(_commonWordsMinPercent ?? 
               (_commonWordsMinPercent = Convert.ToUInt32(_config.GetConfigWithDefault("Option.CommonWordsMinPercent", Convert.ToString((uint)DefaultOptions.CommonWordsMinPercent)))));
      set
      {
        _commonWordsMinPercent = value;
        _config.SetConfig("Option.CommonWordsMinPercent", Convert.ToString(value));
      }
    }

    public uint NumberOfItemsToParse
    {
      get =>
        (uint)(_numberOfItemsToParse ??
               (_numberOfItemsToParse = Convert.ToUInt32(_config.GetConfigWithDefault("Option.NumberOfItemsToParse", Convert.ToString((uint)DefaultOptions.NumberOfItemsToParse)))));
      set
      {
        _numberOfItemsToParse = value;
        _config.SetConfig("Option.NumberOfItemsToParse", Convert.ToString(value));
      }
    }
    
    /// <summary>
    /// Check if we can log given a certain log level.
    /// </summary>
    /// <param name="level"></param>
    /// <returns></returns>
    public bool CanLog(LogLevels level)
    {
      if (level == LogLevels.None)
      {
        return false;
      }

      // if the current level if greater or equal
      // to the level we want to log, then we are good.
      return (LogLevel >= level);
    }

    public Options(IConfig config)
    {
      //  cannot be null.
      _config = config ?? throw new ArgumentNullException(nameof(config));
    }
  }
}
