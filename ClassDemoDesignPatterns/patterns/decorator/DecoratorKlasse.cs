using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDesignPatterns.patterns.decorator
{
    class DecoratorKlasse:IComponent
    {
        private IComponent _component;

        public DecoratorKlasse(IComponent component)
        {
            _component = component;
        }

        public string DoSomething(string str)
        {
            return "Hr " + _component.DoSomething(str);

        }
    }
}
