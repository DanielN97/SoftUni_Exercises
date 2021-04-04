using CollectionHierarchy.Contracts;
using System.Collections.Generic;

namespace CollectionHierarchy.Models
{
    public class AddCollection : IAddCollection
    {
        private List<string> collection;

        public AddCollection()
        {
            collection = new List<string>();
            Collection = collection.AsReadOnly();
        }

        public IReadOnlyList<string> Collection { get; private set; }

        public int Add(string word)
        {
            collection.Add(word);

            return collection.Count - 1;
        }
    }
}
