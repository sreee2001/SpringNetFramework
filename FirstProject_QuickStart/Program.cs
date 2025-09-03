using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Context;
using Spring.Context.Support;

namespace FirstProject_QuickStart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IApplicationContext ctx = new XmlApplicationContext("objects.xml");
            var helloWorld = (HelloWorld)ctx.GetObject("myHelloWorld");
            helloWorld.SayHello();
        }
    }
}
