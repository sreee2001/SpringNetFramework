namespace FirstProject_QuickStart
{
    /// <summary>
    /// The WelcomeCenter coordinates welcoming guests using the MessengerOwl.
    /// </summary>
    public class WelcomeCenter
    {
        /// <summary>
        /// Gets or sets the MessengerOwl used to deliver welcome messages.
        /// </summary>
        public MessengerOwl MessengerOwl{ get; set; }

        /// <summary>
        /// Welcomes the guest by sending a message via the MessengerOwl.
        /// </summary>
        public void WelcomeTheGuest()
        {
            MessengerOwl.DeliverMessage("Dear Visitor, We are pleased to invite you to our Spring.NET QuickStart!");
        }
    }
}