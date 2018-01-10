using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEp4
{
    class Program
    {
        static void Main(string[] args)
        {
			int prod = -1;
	        int i, j;
	        int num;
	        for(i = 0; i <= 999; i++)
	        {
				for (j = 0; j <= 999; j++)
		        {
			        int n = i*j;
					int left = n;
					int rev = 0;
					while (left > 0)
					{
						int r = left % 10;
						rev = rev * 10 + r;
						left = left / 10;  //left = Math.floor(left / 10); 
					}

			        if (rev == n && n >= prod)
			        {
				        prod = n;
			        }
					Console.WriteLine("i = {0}   j = {1}    num = {2}    rev = {3}", i,j,n,rev);
		        }
	        }
			Console.WriteLine("{0}", prod);

			Console.ReadLine();
        }
    }
}
