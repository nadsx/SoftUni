using System;

namespace CustomStack
{
    public class StartUp
    {
        public static void Main()
        {
            StackOfStrings stack = new StackOfStrings();
            Console.WriteLine(stack.IsEmpty());

            stack.AddRange(new[] { "1", "2", "3" });
            Console.WriteLine(stack.IsEmpty());
        }
    }
}
