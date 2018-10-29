using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
//    5.94. Дано шестизначное число.Найти сумму его цифр.Величины для хранения
//всех шести цифр числа не использовать.
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, sum;
            num1 = 123456;
            sum = 0;

            Console.WriteLine("Number is " + num1);
            do
            {
                sum = sum + num1 % 10;
                num1 = num1 / 10;
            } while (num1 > 0);

            Console.WriteLine("Sum is " + sum);
            Console.ReadKey();

        }
    }
}
