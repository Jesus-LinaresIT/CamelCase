using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NumbersWords
{
    class Program
    {
        static void Main(string[] args)
        {
            String Words = "";
            Words = Console.ReadLine();
            int count = 1;


            for (int i = 0; i < Words.Length; i++)
            {

                if (Words[i] >= 'A' && Words[i] <= 'Z')
                {

                    count++;
                }
            }

            Console.WriteLine(count);



        }
    }
}
