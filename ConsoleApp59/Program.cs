using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m=0;
            int[] tab1 = new int[1000];
            do
            {
                Console.WriteLine("n= ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);
            while (n!=0)
            {
                tab1[m++] = n % 2;
                n /= 2;
            }
            Console.Write("In binary that's:");
            for (int j = m - 1; j >= 0; j--) Console.Write(tab1[j]);
            Console.ReadKey();
        }
    }
}
