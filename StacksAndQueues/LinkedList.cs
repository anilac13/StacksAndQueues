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
        public void Delete(int data)
        {
            Node prevNode = head;
            Node currentNode = head.next;
            while (currentNode.data != data)
            {
                if (currentNode.next == null)
                {
                    Console.WriteLine($"The {data} element is not there in Linked list");
                    return;
                }
                prevNode = currentNode;
                currentNode = currentNode.next;
            }
            prevNode.next = currentNode.next;
        }
    }
}
