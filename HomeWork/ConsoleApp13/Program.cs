using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
//    7.120. Известна масса каждого человека из группы.Верно ли, что масса самого тя-
//желого из них превышает массу самого легкого более чем в 2 раза.
    class Program
    {
        static void Main(string[] args)
        {
            List < double > m = new List<double> { 40, 50, 60, 70, 80, 90 };

            double max = m.Max();
            double min = m.Min();

            if (max / min >= 2)
                Console.WriteLine("Max more then min in 2 size ");
            Console.ReadKey();



        }
    }
}
