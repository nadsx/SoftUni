using System;

namespace Farm.Animals
{
    public class Dog : Animal // "Class" - default internal; "Property" - default private 
    {
        public void Bark()
        {
            Console.WriteLine("barking...");
        }
    }
}
