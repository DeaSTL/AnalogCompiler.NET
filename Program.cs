using System;
using filehandling;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            File file = new File("test.anc");
            Console.WriteLine(file.getFileContents());
            file.getRawFileContents();

            Console.ReadLine();
          
        }
    }
}