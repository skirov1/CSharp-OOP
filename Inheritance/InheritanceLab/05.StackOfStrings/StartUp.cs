using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var stack = new StackOfStrings();
            Console.WriteLine(stack.IsEmpty());
        }
    }
}
