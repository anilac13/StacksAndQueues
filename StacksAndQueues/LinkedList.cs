using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class LinkedList
    {
        private Node head;
        public void AddToLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
        }
        public void Display()
        {
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            Console.Write("Elements in Linked list are: ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        public void PeekElement()
        {
            Node temp = head;
            if (head == null)
                return;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            Console.WriteLine($"Peek element in Stack is {temp.data}");
        }
        public void DeleteLast()
        {
            if (head == null)
                return;
            Node secondLast = head;
            Node lastNode = head.next;
            while (lastNode.next != null)
            {
                secondLast = lastNode;
                lastNode = lastNode.next;
            }
            secondLast.next = null;
            Console.WriteLine($"Element popped is {lastNode.data}");
        }
    }
}
