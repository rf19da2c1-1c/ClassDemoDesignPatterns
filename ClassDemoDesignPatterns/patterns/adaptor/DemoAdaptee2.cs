using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDesignPatterns.patterns.adaptor
{
    class DemoAdaptee2
    {
        public string Upper(string str)
        {
            return str.ToUpper();
        }
    }
}
