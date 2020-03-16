using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassDemoDesignPatterns.patterns.singleton;

namespace ClassDemoDesignPatterns.patterns.facade
{
    class SubSystem1
    {
        private List<String> noter = new List<string>();
        public String HentNote(int ix)
        {
            if (0 <= ix && ix < noter.Count)
            {
                return noter[ix];
            }

            throw new ArgumentException("ix not found");
        }

        public void IndsætNote(String note)
        {
            noter.Add(note);
        }
    }
}
