using System;

namespace NumbersWords
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var Words = "";
            Console.WriteLine("Write the sequence of words: ");
            Words = Console.ReadLine();
            var count = 1;


            for (var i = 0; i < Words.Length; i++)
                if (Words[i] >= 'A' && Words[i] <= 'Z')
                    count++;

            Console.WriteLine("Number of words found {0}",count);
        }
    }
}