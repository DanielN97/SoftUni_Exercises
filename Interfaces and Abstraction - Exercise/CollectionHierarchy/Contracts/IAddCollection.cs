using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Contracts
{
    public interface IAddCollection
    {
        IReadOnlyList<string> Collection { get; }

        int Add(string word);
    }
}
