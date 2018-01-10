using System;

namespace PEp6
{
    class Program
    {
        static void Main(string[] args)
        {
	        int sum = 0;
	        for (int i = 1; i <= 100; i++)
	        {
		        sum += (i * i);
	        }
			Console.WriteLine(sum);
	        int sum2 = 0;
	        for (int i = 1; i <= 100; i++)
	        {
		        sum2 += i;
	        }

	        sum2 = (int)Math.Pow(sum2, 2);
	        Console.WriteLine(sum2);
	        int answer = sum2 - sum;
	        Console.WriteLine(answer);
			Console.ReadKey();
        }
    }
}
