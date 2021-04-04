using CollectionHierarchy.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Models
{
    public class AddRemoveCollection : IAddRemoveCollection
    {
        private List<string> collection;

        public AddRemoveCollection()
        {
            collection = new List<string>();
            Collection = collection.AsReadOnly();
        }

        public IReadOnlyList<string> Collection { get; private set; }

        public int Add(string word)
        {
            collection.Insert(0, word);

            return 0;
        }

        public string Remove()
        {
            string word = collection[collection.Count - 1];

            collection.RemoveAt(collection.Count - 1);

            return word;
        }
    }
}
