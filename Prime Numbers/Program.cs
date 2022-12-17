using System;

namespace Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Numbers From");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("To");
            int y = int.Parse(Console.ReadLine());
            if (x==0 || x==1)
            {
                x = 2;
            }
            Console.WriteLine("Prime Numbers Between This Numbers Is:");
            for (; x <= y; x++)
            {
                int z = 0;
                for (int i = 2; i < x; i++)
                {
                    if (x % i ==0)
                    {
                        z = 1; 
                       break;
                    }
                   
                }
                if (z!=1)
                {
                    Console.WriteLine(x);
                }

            }
        }
    }
}
