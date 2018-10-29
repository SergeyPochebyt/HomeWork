using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
//5.71. Гражданин 1 марта открыл счет в банке, вложив 1000 руб.Через каждый ме-
//сяц размер вклада увеличивается на 2% от имеющейся суммы.Определить:
//а) прирост суммы вклада за первый, второй, ..., десятый месяц;
//    б) сумму вклада через три, четыре, ..., двенадцать месяцев.
    class Program
    {
        static void Main(string[] args)
        {
            double s = 1000;
            double k = 1.02;
            double p = 0.02;        

            Console.WriteLine("----Account----");
            for (int i = 1; i <= 12; i++)
            {
                s = s * k;
                Console.WriteLine("After " + i + "mounth - " + s);
            }

            s = 1000;
            Console.WriteLine("----Sum----");
            for (int i = 1; i <= 12; i++)
            {
                double n = s * p;
                s = s * k ;
                Console.WriteLine("After " + i + "mounth - " + n);
            }

            Console.ReadKey();
        }
    }
}
