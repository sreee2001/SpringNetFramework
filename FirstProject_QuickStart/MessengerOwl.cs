using System;

namespace FirstProject_QuickStart
{
    /// <summary>
    /// Represents a magical owl responsible for delivering messages in the fantasy world.
    /// </summary>
    public class MessengerOwl
    {
        /// <summary>
        /// Delivers the specified message to the console.
        /// </summary>
        /// <param name="message">The message to deliver.</param>
        public void DeliverMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}