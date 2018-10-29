using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    //5.9. Напечатать таблицу перевода расстояний в дюймах в сантиметры для значе-ний 10, 11, ..., 22 дюйма(1 дюйм = 25,4 мм). 

    class Program
    {
        static void Main(string[] args)
        {
            const double INCH = 2.54;
            for (int i = 10; i <= 22; i++)
            {
                Console.Write(i + " inch is eqaul {0:#.##}", (i / INCH));
                Console.WriteLine(" sm");
            }
             Console.ReadKey();
        }
    }
}
