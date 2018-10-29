using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    //6.34. Найти 15 первых натуральных чисел, делящихся нацело на 19 и находящихся в интервале, левая граница которого равна 100.
    class Program
    {
        static void Main(string[] args)
        {
            int num, wall, count, fnum;
            wall = 100;
            num = 19;
            count = 15;


            fnum = wall / num + 1;
            
            int k = fnum + count;
            for (int i = fnum; i < k; i++)
            {
                Console.WriteLine(i * num);
            }
            Console.ReadKey();





        }
    }
}
