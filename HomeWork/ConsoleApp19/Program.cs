using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
//    5.82. Составить программу для расчета факториала натурального числа n(фактори-
//ал числа n равен 1 2 ... n ).
    class Program
    {
        static void Main(string[] args)
        {

            int n=5;

            int fact(int k)
            {
                if (k == 1)
                    return 1;
                else
                    return fact(k - 1) * k;
            }
            Console.WriteLine("Factorial " + n + " is " + fact(n));
            Console.ReadKey();


        }
    }
}
