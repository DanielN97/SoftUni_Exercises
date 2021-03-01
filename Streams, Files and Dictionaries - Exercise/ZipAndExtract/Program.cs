using System;
using System.IO;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        string startPath = @"../../../File";
        string zipPath = @"../../../zipFile.zip";
        string extractPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        ZipFile.CreateFromDirectory(startPath, zipPath);

        ZipFile.ExtractToDirectory(zipPath, extractPath);
    }
}