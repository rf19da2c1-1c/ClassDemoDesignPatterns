using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDesignPatterns.patterns.strategy
{
    class ContextClassMoreCSharpLike
    {
        private ICollection<String> _collection;
        private Func<String, String> _strategyMethod;

        public Func<string, string> StrategyMethod
        {
            get => _strategyMethod;
            set => _strategyMethod = value;
        }

        public ContextClassMoreCSharpLike()
        {
            _collection = new List<string>();
        }


        public void InsertStrategyMethod(ICollection<String> strings)
        {
            foreach (string s in strings)
            {
                // the strategy method use an abstract method to be overriden in subclass
                String str = _strategyMethod(s);
                _collection.Add(str);
            }
        }


        public override string ToString()
        {
            return $"Info: [{String.Join(", ", _collection)}]";
        }
    }
}
