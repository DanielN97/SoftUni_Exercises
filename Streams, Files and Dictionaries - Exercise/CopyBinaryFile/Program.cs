using System;
using System.IO;

namespace CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream input = new FileStream("../../../copyMe.png", FileMode.Open))
            {
                using (FileStream output = new FileStream("../../../output.png", FileMode.Create))
                {
                    while (input.Position < input.Length)
                    {
                        byte[] buffer = new byte[4096];

                        input.Read(buffer, 0, buffer.Length);

                        output.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}
