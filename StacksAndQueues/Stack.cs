using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class Stack
    {
        private LinkedList stack = new LinkedList();
        public void Push(int data)
        {
            stack.AddToLast(data);
        }
        public void Display()
        {
            stack.Display();
        }
        public void Peek()
        {
            stack.PeekElement();
        }
        public void Pop()
        {
            stack.DeleteLast();
        }
    }
}
