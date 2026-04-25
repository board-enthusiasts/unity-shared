using UnityEngine;

namespace BE.Unity.Shared.Logging
{
    /// <summary>
    /// Logs through Unity's player/editor console.
    /// </summary>
    public sealed class UnityBeLogger : IBeLogger
    {
        /// <inheritdoc />
        public void Info(string message)
        {
            Debug.Log(message);
        }

        /// <inheritdoc />
        public void Warning(string message)
        {
            Debug.LogWarning(message);
        }

        /// <inheritdoc />
        public void Error(string message)
        {
            Debug.LogError(message);
        }
    }
}

