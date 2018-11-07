using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_7._106
{
    //7.106. Даны натуральное число m и целые числа d1, d2, ..., dm.Выяснить, верно
    //ли, что количество положительных чисел di кратно трем.
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfInts = new List<int>();
            
            Console.WriteLine("Enter size of array");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter numbers in array");
            for (int i = 0; i < n; i++)
                listOfInts.Add(Convert.ToInt32(Console.ReadLine()));

            bool IsPositivMult(List<int> numInts)
            {
                int sum = 0;
                foreach (var i in numInts)
                {
                    if (i > 0)
                    {
                        sum++;
                    }
                }
                if (sum % 3 == 0) return true;
                else return false;
            }

            Console.WriteLine(IsPositivMult(listOfInts));
            Console.ReadKey();
        }
    }
}
