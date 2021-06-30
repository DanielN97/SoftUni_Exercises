using System;

namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>();

            string[] command = Console.ReadLine().Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "END")
            {
                if (command[0] == "Push")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        myStack.Push(int.Parse(command[i].Substring(0, command[i].Length)));
                    }
                }
                else if (command[0] == "Pop")
                {
                    try
                    {
                        myStack.Pop();
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                command = Console.ReadLine().Split();
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (int item in myStack)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
