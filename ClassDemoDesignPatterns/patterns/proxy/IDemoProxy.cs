using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDesignPatterns.patterns.proxy
{
    interface IDemoProxy
    {
        void IndsætString(String str);
        List<String> Hent();
    }
}
