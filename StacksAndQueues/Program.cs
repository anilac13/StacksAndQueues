using System;
namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose option to perform \n1.Add elements to Stack \n2.Display \n3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        stack.Push(56);
                        stack.Push(30);
                        stack.Push(70);
                        break;
                    case 2:
                        stack.Display();
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}