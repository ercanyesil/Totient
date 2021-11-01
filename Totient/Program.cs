using System;

namespace Totient
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Totient(12));
           
        }

        static int Totient(int n)
        {
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                if (obeb(n, i) == 1)
                {
                    count++;
                }
            }
            return count;
        }

        static int obeb(int x, int y)
        {
            int z = 0;

            for (int i = 1; i <= Math.Max(x, y); i++)
            {
                if (x % i == 0 && y % i == 0)
                {
                    z = i;
                }
            }

            return z;
        }
    }
        
}


    

