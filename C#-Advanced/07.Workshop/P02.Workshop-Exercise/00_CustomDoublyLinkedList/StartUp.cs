using System;

namespace _00_CustomDoublyLinkedList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var doubleLinkedList = new DoubleLinkedList();

            doubleLinkedList.AddFirst(2);
            doubleLinkedList.AddLast(4);
            doubleLinkedList.RemoveFirst();
            doubleLinkedList.RemoveLast();

            doubleLinkedList.ForEach(Console.WriteLine, false);
            doubleLinkedList.Clear();

            int[] arr = doubleLinkedList.ToArray();

            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
