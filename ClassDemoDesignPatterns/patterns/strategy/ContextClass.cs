using System;
using System.Collections.Generic;

namespace ClassDemoDesignPatterns.patterns.strategy
{
    class ContextClass
    {
        private ICollection<String> _collection;

        public ContextClass()
        {
            _collection = new List<string>();
        }


        public void InsertStrategyMethod(ICollection<String> strings, IStrategy obj)
        {
            foreach (string s in strings)
            {
                // the strategy method use an abstract method to be overriden in subclass
                String str = obj.MakeString(s);
                _collection.Add(str);
            }
        }


        public override string ToString()
        {
            return $"Info: [{String.Join(", ", _collection)}]";
        }
    }
}
