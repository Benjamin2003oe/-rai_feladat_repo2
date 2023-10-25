using System;

namespace Órai_feladat_git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type in a number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
