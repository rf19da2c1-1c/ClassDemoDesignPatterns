using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDesignPatterns.patterns.factory
{
    class DemoFactoryGenerator
    {
        public static AbstractDemoFactory GetFactory(bool dansk)
        {
            if (dansk) return new DemoFactory();
            
            return new DemoFactoryUK();
        }

    }
}
