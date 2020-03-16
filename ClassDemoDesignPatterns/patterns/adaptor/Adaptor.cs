using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDesignPatterns.patterns.adaptor
{
    class Adaptor:IAdaptor
    {
        private DemoAdaptee1 adaptee = new DemoAdaptee1();
        public string Request(string str)
        {
            return adaptee.KindOfPerson(str);
        }
    }
}
