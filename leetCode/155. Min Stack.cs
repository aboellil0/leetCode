using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    public class MinStack
    {
        private Stack<int> stack = new Stack<int>();
        public MinStack()
        {

        }

        public void Push(int val)
        {
            stack.Push(val);
        }

        public void Pop()
        {
            stack.Pop();
        }

        public int Top()
        {
            return stack.Pop();
        }

        public int GetMin()
        {
           return stack.Min();
        }
    }
}
