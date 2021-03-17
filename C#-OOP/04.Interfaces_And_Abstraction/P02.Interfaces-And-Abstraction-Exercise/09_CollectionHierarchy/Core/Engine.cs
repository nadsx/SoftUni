namespace CollectionHierarchy.Core
{
    using Contracts;
    using Models;

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        private readonly AddCollection addCollection;
        private readonly AddRemoveCollection addRemoveCollection;
        private readonly MyList myList;

        public Engine()
        {
            addCollection = new AddCollection();
            addRemoveCollection = new AddRemoveCollection();
            myList = new MyList();
        }

        public void Run()
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<int> result = new List<int>();

            for (int currentCollection = 1; currentCollection <= 3; currentCollection++)
            {
                foreach (var item in input)
                {
                    switch (currentCollection)
                    {
                        case 1:
                            result.Add(addCollection.Add(item));
                            break;
                        case 2:
                            result.Add(addRemoveCollection.Add(item));
                            break;
                        case 3:
                            result.Add(myList.Add(item));
                            break;
                    }
                }

                Console.WriteLine(string.Join(" ", result));
                result.Clear();
            }

            int removeOperations = int.Parse(Console.ReadLine());

            RemoveItem(removeOperations, addRemoveCollection);
            RemoveItem(removeOperations, myList);
        }

        private void RemoveItem(int count, IRemoveCollection collection)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < count; i++)
            {
                result.Add(collection.Remove());
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
