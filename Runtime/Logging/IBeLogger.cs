namespace BE.Unity.Shared.Logging
{
    /// <summary>
    /// Provides application logging without tying domain code directly to a Unity logging API.
    /// </summary>
    public interface IBeLogger
    {
        /// <summary>
        /// Writes an informational message.
        /// </summary>
        /// <param name="message">The message to write.</param>
        void Info(string message);

        /// <summary>
        /// Writes a warning message.
        /// </summary>
        /// <param name="message">The message to write.</param>
        void Warning(string message);

        /// <summary>
        /// Writes an error message.
        /// </summary>
        /// <param name="message">The message to write.</param>
        void Error(string message);
    }
}

