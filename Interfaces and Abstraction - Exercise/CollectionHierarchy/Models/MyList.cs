using CollectionHierarchy.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Models
{
    public class MyList : IMyList
    {
        private List<string> collection;
        private int used;

        public MyList()
        {
            collection = new List<string>();
            Collection = collection.AsReadOnly();
            Used = used;
        }

        public int Used
        {
            get => used;
            private set
            {
                used = collection.Count;
            }
        }

        public IReadOnlyList<string> Collection { get; private set; }

        public int Add(string word)
        {
            collection.Insert(0, word);

            return 0;
        }

        public string Remove()
        {
            string word = collection[0];

            collection.RemoveAt(0);

            return word;
        }
    }
}
