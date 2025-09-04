using System;

namespace WelcomeToAOP
{
    /// <summary>
    /// Represents a magical owl that delivers messages in the enchanted realm.
    /// </summary>
    public class MessengerOwl
    {
        /// <summary>
        /// Delivers a magical message to the console.
        /// </summary>
        public virtual void DeliverMessage()
        {
            Console.WriteLine("The Messenger Owl delivers a scroll: 'Welcome to the Enchanted AOP Realm!'");
        }
    }
}