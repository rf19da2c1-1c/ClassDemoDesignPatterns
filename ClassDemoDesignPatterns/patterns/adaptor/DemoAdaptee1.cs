using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDesignPatterns.patterns.adaptor
{
    class DemoAdaptee1
    {
        public string KindOfPerson(string str)
        {
            if (str == "peter") return "teacher";

            return "student";
        }
    }
}
