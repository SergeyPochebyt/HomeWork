using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
//    7.64. В некоторых видах спортивных состязаний(например, в фигурном катании)
//выступление каждого спортсмена независимо оценивается несколькими судь-
//ями, затем из всей совокупности оценок удаляются наиболее высокая и наи-
//более низкая, а для оставшихся оценок вычисляется среднее арифметическое,
//которое и идет в зачет спортсмену.Если наиболее высокую оценку выставили
//несколько судей, то из совокупности оценок удаляется только одна такая
//оценка; аналогично поступают и с наиболее низкими оценками.
//Составить программу для расчета оценки, которая пойдет в зачет этому
//спортсмену.

    class Program
    {
        static void Main(string[] args)
        {
            List<double> b = new List<double> { 2, 3, 4, 6, 6, 2 };
           
            double Point(List<double> balls)
            {
                balls.Sort();
                balls.RemoveAt(0);
                balls.RemoveAt(b.Count - 1);
                return balls.Average();
            }

            Console.WriteLine(Point(b));

            Console.ReadKey();

        }
    }
}
