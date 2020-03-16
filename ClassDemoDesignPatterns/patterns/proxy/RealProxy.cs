using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDesignPatterns.patterns.proxy
{
    class RealProxy:IDemoProxy
    {
        private List<String> data = new List<string>();


        public void IndsætString(string str)
        {
            data.Add(str);
        }

        public List<string> Hent()
        {
            return new List<string>(data);
        }
    }
}
