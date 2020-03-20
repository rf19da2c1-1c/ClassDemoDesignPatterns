using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDesignPatterns.patterns.template
{
    class SubTemplate1:AbstractTemplateClass
    {
        protected override string MakeString(string s)
        {
            return s.ToUpper();
        }
    }
}
