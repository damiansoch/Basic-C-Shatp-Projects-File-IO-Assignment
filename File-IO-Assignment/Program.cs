using System;
using System.IO;

namespace File_IO_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write the number");
            string number = Console.ReadLine();

            string path = @"C:\Users\damia\Desktop\Basic_C#_Programs\FileIOAssignment.txt";
            File.WriteAllText(path, number);

            string readText = File.ReadAllText(path);
            Console.WriteLine("Text read from the file is {0}", readText);

            Console.ReadKey();
        }


    }
}
