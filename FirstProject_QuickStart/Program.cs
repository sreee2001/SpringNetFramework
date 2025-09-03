using Spring.Context;
using Spring.Context.Support;

namespace FirstProject_QuickStart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IApplicationContext ctx = new XmlApplicationContext("objects.xml");
            var quickStartWelcomeCenter = (WelcomeCenter)ctx.GetObject("quickStartWelcomeCenter");
            quickStartWelcomeCenter.WelcomeTheGuest();
        }
    }
}
