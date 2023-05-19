using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class Queue
    {
        private LinkedList queue = new LinkedList();
        public void Enqueue(int data)
        {
            queue.AddToLast(data);
        }
        public void Display()
        {
            queue.Display();
        }
    }
}
