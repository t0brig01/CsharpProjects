using System;

namespace PEp7
{
    class Program
    {
        static void Main(string[] args)
        {
	        int finished = 0;
	        int count = 0;
	        int primes = 0;
	        while (finished == 0)
	        {
		        count++;
		        bool isPrime = true;
		        for (int i = 2; i < count; i++)
		        {
			        if (count % i == 0)
			        {
				        isPrime = false;
						Console.WriteLine("Counts = {0}   Primes = {1}",count,primes);
			        }
		        }

		        if (isPrime == true)
		        {
					Console.WriteLine(count);
			        primes++;
		        }

		        if (primes == 10002)
		        {
			        finished = 1;
		        }

	        }

	        Console.WriteLine("Result: Counts = {0}   Primes = {1}", count, primes);
			Console.ReadKey();
        }
    }
}
