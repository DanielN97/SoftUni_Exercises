using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filesNames = Directory.GetFiles(Directory.GetCurrentDirectory());

            Dictionary<string, Dictionary<string, double>> dataBase = new Dictionary<string, Dictionary<string, double>>();

            foreach (string fullFileName in filesNames)
            {
                FileInfo info = new FileInfo(fullFileName);

                string[] nameSplitted = fullFileName.Split(".");
                string name = info.Name;
                string extension = info.Extension;

                if (!dataBase.ContainsKey(extension))
                {
                    dataBase.Add(extension, new Dictionary<string, double>());
                }

                dataBase[extension].Add(info.Name, Math.Round((double)info.Length / 1024, 3));
            }

            List<string> result = new List<string>();

            foreach (var currentExtension in dataBase.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                result.Add($"{currentExtension.Key}");

                foreach (var file in currentExtension.Value.OrderBy(x => x.Value))
                {
                    result.Add($"--{file.Key} - {file.Value}kb");
                }
            }

            File.WriteAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "report.txt"), result);
        }
    }
}
