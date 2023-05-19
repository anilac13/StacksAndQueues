using System;
namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            Queue queue = new Queue();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose option to perform \n1.Add elements to Stack \n2.Display \n3.Peek and Pop elements \n4.Add elements to Queue \n5.Delete element from Queue\n6.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        stack.Push(56);
                        stack.Push(30);
                        stack.Push(70);
                        break;
                    case 2:
                        //stack.Display();
                        queue.Display();
                        break;
                    case 3:
                        stack.Peek();
                        stack.Pop();
                        break;
                    case 4:
                        queue.Enqueue(56);
                        queue.Enqueue(30);
                        queue.Enqueue(70);
                        break;
                    case 5:
                        queue.Dequeue();
                        break;
                    case 6:
                        flag = false;
                        break;
                }
            }
        }
    }
}