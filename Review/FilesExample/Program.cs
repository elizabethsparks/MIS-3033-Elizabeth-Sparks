using System;
using System.IO;

namespace FilesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = ""; @"C:\Users\Elizabeth Sparks\Downloads\Pride and Prejudice by Jane Austen.txt
           
                var lines =  File.ReadAllText(filePath);
          
            for (int i = 0; i < lines.Length; i++)
            {
                string currentLIne = lines[i];
                if (currentLIne.Contains("Chapter"));
                {
                    Console.ReadKey();
                }
                Console.WriteLine(currentLIne);
            }



        }
    }
}
