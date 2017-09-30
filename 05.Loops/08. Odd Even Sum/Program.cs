using System;

namespace _08.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int even = 0;
            int odd = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    even = even + num;
                }
                else if (i % 2 != 0)
                {
                    odd = odd + num;
                }
            }

            int abs = Math.Abs(even - odd);

            if (even == odd)
            {
                Console.WriteLine("Yes \nSum = " + even);
            }
            else if (even != odd)
            {
                Console.WriteLine("No \nDiff = " + abs);
            }

        }
    }
}