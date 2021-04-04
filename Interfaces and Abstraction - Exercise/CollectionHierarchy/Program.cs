using CollectionHierarchy.Contracts;
using CollectionHierarchy.Models;
using System;
using System.Collections.Generic;

namespace CollectionHierarchy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IAddCollection> allCollections = new List<IAddCollection>();
            List<IAddRemoveCollection> allRemovableCollections = new List<IAddRemoveCollection>();

            AddCollection addCollection = new AddCollection();
            allCollections.Add(addCollection);

            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            allCollections.Add(addRemoveCollection);
            allRemovableCollections.Add(addRemoveCollection);

            MyList myList = new MyList();
            allCollections.Add(myList);
            allRemovableCollections.Add(myList);

            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (IAddCollection collection in allCollections)
            {
                foreach (string word in words)
                {
                    Console.Write($"{collection.Add(word)} ");
                }

                Console.WriteLine();
            }

            int n = int.Parse(Console.ReadLine());

            foreach (IAddRemoveCollection collection in allRemovableCollections)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{collection.Remove()} ");
                }

                Console.WriteLine();
            }
        }
    }
}
