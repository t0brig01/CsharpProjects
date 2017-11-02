using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEp2
{
    class Program
    {
        static int FibSeq(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
            {
                return FibSeq(n - 1) + FibSeq(n - 2);
            }
        }
        static void Main(string[] args)
        {
            int i = 0;
            int sum = 0;
            while (FibSeq(i) < 4000000)
            {
                if (FibSeq(i) % 2 == 0)
                {
                    sum += FibSeq(i);
                }
                i++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
