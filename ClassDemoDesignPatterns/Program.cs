using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            DesignPatternWorker worker = new DesignPatternWorker();
            worker.Start();

            Console.ReadLine();
        }
    }
}
