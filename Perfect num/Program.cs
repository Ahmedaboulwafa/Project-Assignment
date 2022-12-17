using System;

namespace Perfect_num
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Numbers From");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("To");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Perfect Numbers Between This Numbers Is:");
            for (; x <= y; x++)
            {
                int sum = 0;
                for (int i = 1; i < x; i++)
                {
                    if (x % i == 0 )
                    {
                        sum += i;

                    }
                }
                if (x==sum)
                {
                    Console.WriteLine(x);
                }
               
            }
        }
    }
}
