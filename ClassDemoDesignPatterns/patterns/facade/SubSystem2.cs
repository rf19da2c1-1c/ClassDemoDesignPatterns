using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassDemoDesignPatterns.patterns.singleton;

namespace ClassDemoDesignPatterns.patterns.facade
{
    class SubSystem2
    {
        private NoteKatalog indkøb = NoteKatalog.Instans;

        public SubSystem2()
        {
            indkøb.Clear();
            indkøb.Add("mælk");
            indkøb.Add("salt");
        }

        public List<String> HentIndkøbsliste()
        {
            return indkøb.Noter;
        }

        public void TilføjIndkøb(String endnuEtIndkøb)
        {
            indkøb.Add(endnuEtIndkøb);
        }
    }
}
