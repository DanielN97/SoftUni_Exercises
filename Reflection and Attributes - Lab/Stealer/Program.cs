using System;

namespace Stealer
{
    class Program
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            string result = spy.AnalyzeAccessModifiers("Stealer.Hacker");
            Console.WriteLine(result);
        }
    }
}
