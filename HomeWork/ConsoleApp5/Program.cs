using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    //6.9. Среди чисел 1, 4, 9, 16, 25, ... найти первое число, большее n. 
    class Program
    {
        static void Main(string[] args)
        {
            double i, n, k;
            i = 1;
            Console.WriteLine("Enter n");
            n = Convert.ToDouble(Console.ReadLine());
            do
            {
                k = Math.Pow(i, 2);
                i++;
            }
            while (k < n);
            Console.WriteLine(n);
            Console.WriteLine(k);
            Console.ReadKey();    

        }
    }
}
