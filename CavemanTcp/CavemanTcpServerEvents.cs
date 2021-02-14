﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CavemanTcp
{
    /// <summary>
    /// CavemanTcp server events.
    /// </summary>
    public class CavemanTcpServerEvents
    {
        #region Public-Members

        /// <summary>
        /// Event to fire when a client connects.  A string containing the client IP:port will be passed.
        /// </summary>
        public event EventHandler<ClientConnectedEventArgs> ClientConnected;

        /// <summary>
        /// Event to fire when a client disconnects.  A string containing the client IP:port will be passed.
        /// </summary>
        public event EventHandler<ClientDisconnectedEventArgs> ClientDisconnected;

        /*
        /// <summary>
        /// Event to fire when an exception is encountered.
        /// </summary>
        public event EventHandler<UnhandledExceptionEventArgs> ExceptionEncountered;
        */

        #endregion

        #region Private-Members

        #endregion

        #region Constructors-and-Factories

        /// <summary>
        /// Instantiate the object.
        /// </summary>
        public CavemanTcpServerEvents()
        {

        }

        #endregion

        #region Public-Methods

        #endregion

        #region Internal-Methods
         
        internal void HandleClientConnected(object sender, ClientConnectedEventArgs args)
        {
            ClientConnected?.Invoke(sender, args);
        }

        internal void HandleClientDisconnected(object sender, ClientDisconnectedEventArgs args)
        {
            ClientDisconnected?.Invoke(sender, args);
        }

        internal void HandleExceptionEncountered(object sender, Exception e)
        {
            UnhandledExceptionEventArgs u = new UnhandledExceptionEventArgs(e, true);
            // ExceptionEncountered?.Invoke(sender, u);
        }

        #endregion

        #region Private-Methods

        #endregion
    }
}
