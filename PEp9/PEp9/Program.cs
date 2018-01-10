using System;
using System.ComponentModel;

namespace PEp9
{
    class Program
    {
        static void Main(string[] args)
        {
            double c;
            for (int i = 1; i < 1000; i++)
            {
                for (int j = 1; j < 1000; j++)
                {
                    c = Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j,2));
                    if (c % 1 == 0)
                    {
                        if ((i + j + c) == 1000)
                        {
                            Console.WriteLine("a = {0}\t b = {1}\t c = {2}",i,j,c);
                            Console.WriteLine(i*j*c);
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
