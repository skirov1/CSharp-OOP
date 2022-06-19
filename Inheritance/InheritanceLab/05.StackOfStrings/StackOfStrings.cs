using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        private Stack<string> stack = new Stack<string>();

        public bool IsEmpty()
        {
            if (stack.Count <= 0)
            {
                return true;
            }
            return false;
        }

        public Stack<string> AddRange(Stack<string> stackToAdd)
        {
            foreach (var item in stackToAdd)
            {
                stack.Push(item);
            }
            return stack;
        }
    }
}
