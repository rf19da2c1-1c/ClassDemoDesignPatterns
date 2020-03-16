using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDesignPatterns.patterns.singleton
{
    public class NoteKatalog
    {
        // singleton

        // trin 1
        private static NoteKatalog instans = new NoteKatalog(); // eager


        // trin 2 -- egentlig variant factory
        public static NoteKatalog Instans => instans;

        // trin 3
        private NoteKatalog()
        {
            this.noter = new List<string>()
            {
                "note1", "note2", "og note3"
            };
        }

        // Singleton slut


        private List<String> noter;

        public List<string> Noter => new List<string>(noter);

        

        public void Add(string item)
        {
            noter.Add(item);
        }

        public void Clear()
        {
            noter.Clear();
        }


        public override string ToString()
        {
            String strNoter = String.Join("\n", noter);
            return $"Noter er \n{strNoter}";
        }
    }
}
