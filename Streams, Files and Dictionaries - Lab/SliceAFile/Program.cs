using System;
using System.IO;

namespace SliceAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fileStream = new FileStream("../../../sliceMe.txt", FileMode.Open))
            {
                int chunkSize = (int)Math.Ceiling(fileStream.Length / 4.0);

                for (int i = 1; i <= 4; i++)
                {
                    byte[] buffer = new byte[1];

                    int count = 0;

                    using (FileStream writeStream = new FileStream($"../../../Part-{i}.txt", FileMode.Create))
                    {
                        while (count < chunkSize)
                        {
                            fileStream.Read(buffer, 0, buffer.Length);

                            writeStream.Write(buffer, 0, buffer.Length);

                            count += buffer.Length;
                        }

                        if (fileStream.Position != fileStream.Length && i == 4)
                        {
                            byte[] lastBuffer = new byte[fileStream.Length - fileStream.Position];
                            fileStream.Read(lastBuffer, 0, lastBuffer.Length);
                            writeStream.Write(lastBuffer, 0, lastBuffer.Length);
                        }
                    }
                }
            }
        }
    }
}
