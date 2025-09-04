using Spring.Context;
using Spring.Context.Support;

namespace FirstProject_QuickStart
{
    /// <summary>
    /// Entry point for the FirstProject_QuickStart application.
    /// Loads the Spring.NET context and triggers the welcome process.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Load the Spring.NET application context from objects.xml
            IApplicationContext ctx = new XmlApplicationContext("objects.xml");
            // Retrieve the WelcomeCenter bean and invoke the welcome method
            var quickStartWelcomeCenter = (WelcomeCenter)ctx.GetObject("quickStartWelcomeCenter");
            quickStartWelcomeCenter.WelcomeTheGuest();
        }
    }
}
