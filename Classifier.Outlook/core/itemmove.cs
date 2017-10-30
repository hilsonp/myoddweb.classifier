﻿using System;
using System.Collections;
using System.Collections.Generic;
using myoddweb.classifier.interfaces;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace myoddweb.classifier.core
{
  public class ItemMove : IDisposable
  {
    /// <summary>
    /// The folders we are currently 'observing'
    /// </summary>
    private Dictionary<string, Outlook.Folder> _observedFolders = new Dictionary<string, Outlook.Folder>();

    /// <summary>
    /// The current mail processor.
    /// </summary>
    private readonly IMailProcessor _mailProcessor;

    /// <summary>
    /// The logger
    /// </summary>
    private readonly ILogger _logger;

    /// <summary>
    /// The constructor.
    /// </summary>
    /// <param name="mailProcessor">The mail processor</param>
    /// <param name="logger"></param>
    public ItemMove( IMailProcessor mailProcessor, ILogger logger )
    {
      if (mailProcessor == null)
      {
        throw new ArgumentNullException(nameof(mailProcessor));
      }
      if (logger == null)
      {
        throw new ArgumentNullException(nameof(logger));
      }
      _mailProcessor = mailProcessor;
      _logger = logger;
    }

    public void Monitor( Outlook._Folders folders)
    {
      //  remove whatever we might be monitoring
      UnRegisterAllFolders();

      // then start monitoring
      RegisterAllFolders( folders );
    }

    public void Dispose()
    {
      // unregister everything.
      UnRegisterAllFolders();
    }

    /// <summary>
    /// Unregister all the folders been observed.
    /// </summary>
    private void UnRegisterAllFolders()
    {
      foreach (var folder in _observedFolders)
      {
        folder.Value.BeforeItemMove -= BeforeItemMove;
      }

      // reset everything
      _observedFolders = new Dictionary<string, Outlook.Folder>();
    }

    /// <summary>
    /// Register all the folders.
    /// </summary>
    /// <param name="folders"></param>
    private void RegisterAllFolders(IEnumerable folders)
    {
      foreach (var item in folders)
      {
        RegisterFolder(item as Outlook.Folder);
      }
    }

    /// <summary>
    /// Register a single folder for actions.
    /// </summary>
    /// <param name="folder"></param>
    private void RegisterFolder(Outlook.Folder folder)
    {
      if (null == folder)
      {
        return;
      }

      // remember to remove the new functions
      // @see UnRegisterAllFolders(...)
      _observedFolders[folder.EntryID] = folder;
      folder.BeforeItemMove += BeforeItemMove;

      // register all the sub folders of that folder.
      RegisterAllFolders(folder.Folders);
    }

    private void BeforeItemMove(object item, Outlook.MAPIFolder moveto, ref bool cancel)
    {
      try
      {
        var mailItem = (Outlook._MailItem)item;
        if (mailItem == null)
        {
          return;
        }

        // get the item id
        var itemId = mailItem.EntryID;

        // are we currently processing this item?
        if (_mailProcessor.IsProccessing(itemId))
        {
          return;
        }

        // is it something we even care about
        if (!_mailProcessor.IsUsableClassNameForClassification(mailItem.MessageClass))
        {
          return;
        }

        // get the new folder id
        // var folderId = moveto.EntryID;

        _logger.LogVerbose($"About to move mail '{mailItem.Subject}' to folder '{moveto.Name}'");
      }
      catch (Exception e)
      {
        _logger.LogException(e);
      }
    }
  }
}
