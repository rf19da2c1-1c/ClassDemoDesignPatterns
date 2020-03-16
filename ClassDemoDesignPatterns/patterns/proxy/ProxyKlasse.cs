using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDesignPatterns.patterns.proxy
{
    class ProxyKlasse:IDemoProxy
    {
        private string _fag;
        private IDemoProxy _real;

        public ProxyKlasse(String fag)
        {
            _fag = fag;
            _real = new RealProxy();
        }

        public void IndsætString(string str)
        {
            _real.IndsætString($"{str} underviser i {_fag}");
        }

        public List<string> Hent()
        {
            return _real.Hent();
        }
    }
}
