using System;
using System.Collections.Generic;
using System.Globalization;

namespace PEp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int num = 0;
            int div = 0;
            while (div <= 501)
            {
                div = 0;
                i++;
                num += i;
                int end = (int) Math.Sqrt(num);
                for (int j = 1; j <= end; j++)
                {
                    if (num % j == 0)
                    {
                        div+=2;
                    }
                }
                Console.WriteLine("num = {0}\t div = {1}", num, div);
            }
            Console.WriteLine("num = {0}\t div = {1}",num,div);
            Console.ReadKey();
        }
    }
}
