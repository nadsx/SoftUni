using System;

namespace _09_CustomLinkedList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //#1
            var doubleLinkedList = new DoubleLinkedList<int>(); 

            doubleLinkedList.AddFirst(1);
            doubleLinkedList.AddFirst(2);
            doubleLinkedList.AddFirst(3);
            doubleLinkedList.AddFirst(4);

            //#2

            //var doubleLinkedList = new DoubleLinkedList<string>();
            //doubleLinkedList.AddFirst("1"); 
            //doubleLinkedList.AddFirst("2");
            //doubleLinkedList.AddFirst("3");
            //doubleLinkedList.AddFirst("4");

            doubleLinkedList.ForEach(Console.WriteLine);      
        }
    }
}
