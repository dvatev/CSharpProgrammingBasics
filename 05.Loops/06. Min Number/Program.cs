﻿using System;

namespace _06.Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = 1111111111;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < min)
                    min = num;
            }

            Console.WriteLine(min);
        }
    }
}