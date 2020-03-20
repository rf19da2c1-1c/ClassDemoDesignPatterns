using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDesignPatterns.patterns.decorator
{
    class DecoratorKlasse2 : IComponent
    {
        private IComponent _component;

        public DecoratorKlasse2(IComponent component)
        {
            _component = component;
        }

        public string DoSomething(string str)
        {
            return  _component.DoSomething(str) + " Levinsky";

        }
    
    }
}
