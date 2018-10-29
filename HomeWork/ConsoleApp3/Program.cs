using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
//    5.67. Последовательность Фибоначчи образуется так: первый и второй члены по-
//следовательности равны 1, каждый следующий равен сумме двух предыду-
//щих(1, 1, 2, 3, 5, 8, 13, ...). Дано натуральное число n(n 3).
//а) Найти k-й член последовательности Фибоначчи.
//б) Получить первые n членов последовательности Фибоначчи.
//в) Верно ли, что сумма первых n членов последовательности Фибоначчи есть
//четное число?


    class Program
    {
        static void Main(string[] args)
        {
            int count;
            int[] fibonachi;
           
            count = 7;
                       
            int CountFib(int n)
            {
                if (n == 0) return 0;
                if (n == 1) return 1;
                return CountFib(n - 1) + CountFib(n - 2);
            }
            Console.WriteLine("a");
            Console.WriteLine(count + "-th fibonachi is " + CountFib(count));

            Console.WriteLine("b");
            Console.WriteLine("List of " + count + " number fibonachi");
            fibonachi = new int[count];
            for (int i = 1; i <= count; i++)
            {
                fibonachi[i-1] = CountFib(i);
                Console.WriteLine(i + "-th fibonachi is " + CountFib(i));
            }

            Console.WriteLine("c");
            if (fibonachi.Sum() % 2 == 0)
                Console.WriteLine("Sum is chet" + fibonachi.Sum());
            else Console.WriteLine("Sum is not chet" + fibonachi.Sum());

            Console.ReadKey();
        }
    }
}
