using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDesignPatterns.patterns.decorator
{
    class ConcreteComponent:IComponent
    {
        public String DoSomething(string str)
        {
            // do nothing just return

            return str;
        }
    }
}
