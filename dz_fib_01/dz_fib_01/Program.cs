using System;

namespace dz_fib_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во числе: ");
            int k = Int32.Parse(Console.ReadLine());
            long[] nums = new long[k];
            nums[0] = 1;
            nums[1] = 1;
            for (int i = 2; i < k; i++)
            {
                nums[i] = nums[i - 1] + nums[i - 2];
            }
            Console.WriteLine("Числа Фибоначчи:");
            int p = 1;
            foreach (int x in nums)
            {
                Console.Write($"{x}\t");
                if (p % 10 == 0)
                {
                    Console.WriteLine();
                }
                p++;
            }
        }
    }
}
