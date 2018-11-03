using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_7._127
{
    //7.127. Дано натуральное число.Выяснить, является ли оно простым(простым на-
    //зывается натуральное число, большее 1, не имеющее других делителей, кро-
    //ме единицы и самого себя). Оператор цикла с условием не использовать
    //(см.также задачу 6.52).
    class Program
    {
        static void Main(string[] args)
        {
            bool IsSimple(int k)
            {
                bool flag = true;
                for (int i = 2; i < k; i++)
                {
                    if (k % i == 0)
                        flag = false;
                }
                return flag;
            }

            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is simple - " + IsSimple(n));
            Console.ReadKey();

        }
    }
}
