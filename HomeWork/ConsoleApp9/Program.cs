using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork

{
//    6.99. Начав тренировки, лыжник в первый день пробежал 10 км.Каждый следую-щий день он увеличивал пробег на 10% от пробега предыдущего дня.Опре- делить:
//а) в какой день он пробежит больше 20 км;
//б) в какой день суммарный пробег за все дни превысит 100 км.

    class Program
    {
        static void Main(string[] args)
        {
            double path, change, l1, l2, l3;
            int day;
            l1 = 20;
            l2 = 100;
            change = 1.1;
            path = 10;
            day = 0;
            l3 = 0;
            do
            {
                path = path * change;
                day++;
            }
            while (path < l1);
            Console.WriteLine("a/ days - " + (day+1) + " path  " + path);

            day = 0;
            path = 10;

            do
            {
                l3 = l3 + path;
                path = path * change;
                day++;
            }
            while (l3 < l2);
            Console.WriteLine("b/ days - " + day + " path " + l3);



            Console.ReadKey();

        }
    }
}
