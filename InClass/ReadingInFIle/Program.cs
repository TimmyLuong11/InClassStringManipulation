using System;
using System.IO;

namespace ReadingInFIle
{
    class Program
    {
        static void Main(string[] args)
        {
            //C:\Users\Kimlu\Desktop\Sidewinders From Sirius by Fox B. Holden.txt
            string[] linesofBook = File.ReadAllLines("Sidewinders From Sirius by Fox B. Holden.txt");
            string book = File.ReadAllText("Sidewinders From Sirius by Fox B. Holden.txt");
            Console.WriteLine(book);

            //string book = File.ReadAllText(PATH);
        }
    }
}
