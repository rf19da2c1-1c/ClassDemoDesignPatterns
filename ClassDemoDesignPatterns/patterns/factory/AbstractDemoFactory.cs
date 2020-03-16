using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDesignPatterns.patterns.factory
{
     abstract class AbstractDemoFactory
    {
        public abstract  IDemoFactory GetClass(string form);
    }
}
