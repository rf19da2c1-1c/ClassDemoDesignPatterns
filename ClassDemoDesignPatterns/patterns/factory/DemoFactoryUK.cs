using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDesignPatterns.patterns.factory
{
    class DemoFactoryUK:AbstractDemoFactory
    {
        public override IDemoFactory GetClass(string form)
        {
            // returnere et object af en klasse 
            if (form == "friendly") return new DemoFactoryFriendlyUK();
            if (form == "polite") return new DemoFactoryPoliteUK();

            return new DemoFactoryDefault();

        }
    }
}
