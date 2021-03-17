using System;
using System.Diagnostics;

namespace _00_CustomDataStructures
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            CustomStack stack = new CustomStack();

            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }

            Debug.Assert(stack.Count == 10);
            stack.ForEach(x => Console.WriteLine(x));

            CustomList list = new CustomList();

            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }

            Debug.Assert(list[2] == 2);
            Debug.Assert(list.Count == 10);

            list.RemoveAt(2);
            Debug.Assert(list[2] == 3);
            Debug.Assert(list[3] == 4);
            Debug.Assert(list.Count == 9);

            list.Reverse();
            Debug.Assert(list.Count == 9);
            Debug.Assert(list[0] == 9);
            Debug.Assert(list[1] == 8);
            Debug.Assert(list[2] == 7);
        }
    }
}
