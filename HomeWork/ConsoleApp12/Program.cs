using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
//    7.128. Натуральное число называется совершенным, если оно равно сумме своих
//делителей, включая 1 и, естественно, исключая это самое число.Например,
//число 6 — совершенное ( 6 1 2 3 ). Дано натуральное число.Выяснить,
//является ли оно совершенным.

    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;

            bool Perfect (int k)
            {
                int sum = 0;
                for (int i = 1; i < k; i++)
                    {
                        if (k % i == 0)
                        sum += i;
                    }
                if (k == sum)
                    return true;
                else return false;
                        
            }
            for (int i = 1; i <= 100000000; i++)
            {
                if (Perfect(i))
                Console.WriteLine(i + " is perfect " + Perfect(i));
            }
            Console.ReadKey();

        }
    }
}
