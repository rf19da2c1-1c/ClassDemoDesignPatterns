using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDesignPatterns.patterns.factory
{
    class DemoFactory:AbstractDemoFactory
    {
        // skal være statisk
        public override IDemoFactory GetClass(string form)
        {
            // returnere et object af en klasse 
            if (form == "friendly") return new DemoFactoryFriendly();
            if (form == "polite") return new DemoFactoryPolite();

            return new DemoFactoryDefault();
        }

        
    }
}
