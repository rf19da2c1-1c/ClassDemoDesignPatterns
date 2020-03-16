using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDesignPatterns.patterns.facade
{
    class Facade
    {
        private SubSystem1 sub1 = new SubSystem1();
        private SubSystem2 sub2 = new SubSystem2();


        public void NyNote(String str)
        {
            sub1.IndsætNote(str);
        }

        public String HentNote(int ix)
        {
            return sub1.HentNote(ix);
        }

        public void NytIndkøb(String str)
        {
            sub2.TilføjIndkøb(str);
        }

        public List<String> HvadSkalJegKøbe()
        {
            return sub2.HentIndkøbsliste();
        }
    }
}
