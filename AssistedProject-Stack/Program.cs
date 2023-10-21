using AssistedProject_Stack;
using System;

namespace AssistedProject_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            Stack stack = new Stack();

            Console.WriteLine("length of stack=" + stack.getLengthOfStack());
            if (stack.peek() == null)
                Console.WriteLine("Stack contains nothing");
            Console.WriteLine("**********************************");
            for (int i = 0; i < 10; i++)
            {
                Node n = new Node();
                n.Data = i.ToString();
                stack.push(n);
                Console.WriteLine("Length of stack=" + stack.getLengthOfStack());
            }
            Console.WriteLine("**********************************");
            Node node = stack.pop();
            Console.WriteLine("Popped " + node.Data);
            Console.WriteLine("**********************************");
            node = stack.pop();
            Console.WriteLine("Popped " + node.Data);
            Console.WriteLine("**********************************");

            Console.WriteLine("Stack items");
            Console.WriteLine(stack.listContents());
            Console.WriteLine("**********************************");

            Console.ReadLine();
        }
    }
}
