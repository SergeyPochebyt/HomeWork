using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    //    5.77.* Найти сумму 2 2 2 2 2 1 2 3 4 ... 10 .. Условный оператор не использо-
    //вать.
    class Program
    {
        static void Main(string[] args)
        {
            int sing = -1;
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + sing * i * i;
                sing = sing * (-1);
            }

            Console.WriteLine("Sum is " + sum);
            Console.ReadKey();
        }
    }
}
