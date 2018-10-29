using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    //6.114. Дано натуральное число.Найти его наименьший делитель, отличный от 1.
    class Program
    {
        static void Main(string[] args)
        {

            int n = 1345;

            for (int i = 2; i <= n; i++)
                if (n % i == 0)
                {
                    Console.WriteLine("Min del " + n + " is " + i);
                    break;
                }
            Console.ReadKey();

        }
    }
}
