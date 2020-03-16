using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDesignPatterns.patterns.factory
{
    class DemoFactoryPoliteUK:IDemoFactory
    {
        public void Print(string navn)
        {
            Console.WriteLine($"Dear {navn}");
        }
    }
}
