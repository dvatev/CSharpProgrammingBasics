﻿using System;

namespace _11.OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }
}

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddevensum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");

            var n = int.Parse(Console.ReadLine());

            double maxOdd = double.MinValue;
            double minOdd = double.MaxValue;

            double maxEven = double.MinValue;
            double minEven = double.MaxValue;

            double sumOfEven = 0.0;
            double sumOfOdd = 0.0;

            if (n == 0)

            {
                Console.WriteLine("OddSum=0, OddMin=No, OddMax=No, EvenSum=0, EvenMin=No, EvenMax=No");
            }

            if (n == 1)

            {
                double num = int.Parse(Console.ReadLine());
                Console.WriteLine("OddSum={0}, OddMin={0}, OddMax={0}, EvenSum=0, EvenMin=No, EvenMax=No", num);
            }

            if (n > 1)

            {

                for (int i = 1; i <= n; i++)
                {

                    if (i % 2 != 0)
                    {
                        double num = double.Parse(Console.ReadLine());
                        sumOfOdd += num;
                        if (num > maxOdd)
                            maxOdd = num;
                        if (num < minOdd)
                            minOdd = num;
                    }
                    else
                    {
                        double num = double.Parse(Console.ReadLine());
                        sumOfEven += num;
                        if (num > maxEven)
                            maxEven = num;
                        if (num < minEven)
                            minEven = num;
                    }
                }
                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", sumOfOdd, minOdd, maxOdd, sumOfEven, minEven, maxEven);
            }

        }
    }
}
*/