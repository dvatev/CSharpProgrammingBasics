using System;

namespace _02.Numbers_Ending_in_7
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int num = 0; num < 1000; num++)
                if (num % 10 == 7)
                    Console.WriteLine(num);
        }
    }
}