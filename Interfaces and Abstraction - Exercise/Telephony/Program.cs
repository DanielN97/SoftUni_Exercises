using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phones = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string[] urls = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryphone = new StationaryPhone();

            foreach (string number in phones)
            {
                try
                {
                    string result = number.Length == 10
                        ? smartphone.Calling(number)
                        : stationaryphone.Calling(number);

                    Console.WriteLine(result);
                }
                catch (InvalidOperationException exeption)
                {
                    Console.WriteLine(exeption.Message);
                }
            }

            foreach (string url in urls)
            {
                try
                {
                    Console.WriteLine(smartphone.Browsing(url));
                }
                catch (InvalidOperationException exeption)
                {
                    Console.WriteLine(exeption.Message);
                }
            }
        }
    }
}
