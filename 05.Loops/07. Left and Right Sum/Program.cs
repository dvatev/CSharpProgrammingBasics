using System;

namespace _07.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lSum = 0;
            int rSum = 0;
            for (int i = 0; i < n; i++)
            {
                int leftSum = int.Parse(Console.ReadLine());
                lSum = lSum + leftSum;
            }
            for (int i = 0; i < n; i++)
            {
                int rightSum = int.Parse(Console.ReadLine());
                rSum = rSum + rightSum;
            }
            int total = Math.Abs(lSum - rSum);
            if (total == 0)
            {
                Console.WriteLine("Yes, sum = " + lSum);
            }
            else if (total != 0)
            {
                Console.WriteLine("No, diff = " + total);
            }

        }
    }
}