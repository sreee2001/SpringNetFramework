namespace FirstProject_QuickStart
{
    public class WelcomeCenter
    {
        public MessengerOwl MessengerOwl{ get; set; }

        public void WelcomeTheGuest()
        {
            MessengerOwl.DeliverMessage("Dear Visitor, We are pleased to invite you to our Spring.NET QuickStart!");
        }
    }
}