using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEp3
{
    class Program
    {
        static public long maxPrime(long n)
        {
            long l = 2;
            while (l*l <= n)
            {
                if (n % l == 0)
                {
                    n /= l;
                }
                else
                {
                    l++;
                }
            }
            return n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(maxPrime(600851475143));
            Console.ReadKey();
        }
    }
}
