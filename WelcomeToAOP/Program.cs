using Spring.Context;
using Spring.Context.Support;
using System;

namespace WelcomeToAOP
{
    /// <summary>
    /// Entry point for the WelcomeToAOP application.
    /// Demonstrates AOP by invoking the MessengerOwl through a proxy with magical interception.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Ensure the console supports Unicode for magical symbols
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Load the Spring.NET application context from objects.xml
            IApplicationContext ctx = new XmlApplicationContext("objects.xml");
            // Retrieve the MessengerOwl proxy and deliver the message
            var owl = (MessengerOwl)ctx.GetObject("owlProxy");
            owl.DeliverMessage();
        }
    }
}