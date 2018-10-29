using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
//    6.52. Дано натуральное число.Выяснить, является ли оно простым(простым назы-
//вается натуральное число, большее 1, не имеющее других делителей, кроме
//единицы и самого себя). Оператор цикла с параметром не использовать.

    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter num");
            n = Convert.ToInt32(Console.ReadLine());
            int k =(int) Math.Sqrt(10);
            bool flag = false;

            for (int i = 2; i <= k; i++)
            {
                if ((n % i) == 0)
                {
                    flag = true;
                    Console.WriteLine("number is not simple");
                    break;
                }
            }
            if (flag == false)
                Console.WriteLine("number is simple");

            Console.ReadKey();
        }
    }
}
