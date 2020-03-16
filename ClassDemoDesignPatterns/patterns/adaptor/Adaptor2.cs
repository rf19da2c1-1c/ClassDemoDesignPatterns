using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDesignPatterns.patterns.adaptor
{
    class Adaptor2:IAdaptor
    {
        private DemoAdaptee2 adaptee = new DemoAdaptee2();
        public string Request(string str)
        {
            return adaptee.Upper(str);
        }
    }
}
