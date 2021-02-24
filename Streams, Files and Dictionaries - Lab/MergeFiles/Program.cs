using System;
using System.IO;

namespace MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader firstReader = new StreamReader(@"../../../FileOne.txt"))
            {
                using (StreamReader secondReader = new StreamReader(@"../../../FileTwo.txt"))
                {
                    using (StreamWriter writer = new StreamWriter(@"../../../Output.txt"))
                    {
                        int counter = 0;

                        while (firstReader.Peek() > 0 || secondReader.Peek() > 0)
                        {
                            if (counter % 2 == 0)
                            {
                                writer.WriteLine(firstReader.ReadLine());
                            }
                            else
                            {
                                writer.WriteLine(secondReader.ReadLine());
                            }

                            counter++;
                        }
                    }
                }
            }
        }
    }
}
