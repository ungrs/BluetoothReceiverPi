using System;
using System.ComponentModel;

namespace RSwash
{
    /// <summary>
    /// The ReceiverBluetoothService interface.
    /// </summary>

    public interface IReceiverService
    {
        /// <summary>
        /// Gets a value indicating whether was started.
        /// </summary>
        /// <value>
        /// The was started.
        /// </value>
        bool IsStarted { get; }

        /// <summary>
        /// Starts the listening from Senders.
        /// </summary>
        /// <param name="reportAction">
        /// The report Action.
        /// </param>
        void Start(Action<string> reportAction);

        /// <summary>
        /// Stops the listening from Senders.
        /// </summary>
        void Stop();

        /// <summary>
        /// Occurs when [property changed].
        /// </summary>
        event PropertyChangedEventHandler PropertyChanged;
    }
}

