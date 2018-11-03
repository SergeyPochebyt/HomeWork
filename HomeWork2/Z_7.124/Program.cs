using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_7._124
{
    //7.124. Даны 20 чисел, образующие неубывающую последовательность.Несколько
    //чисел, идущие подряд, равны между собой.Найти количество таких чисел.
    //Сколько различных чисел имеется в последовательности?

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new[] {1, 2, 3, 3, 4, 5, 6, 7, 7, 8, 9, 9, 9, 5, 7, 8, 5, 7, 9, 10};
            
            int EqualeCouple(int[] arrInts)
            {
                int count = 0;
                for (int i = 1; i < arrInts.Length; i++)
                {
                    if (arrInts[i] == arrInts[i - 1])
                        count++;
                }
                return count;
            }

            int NotMatch(int[] arrInts)
            {
                int count = 0;
                for (int i = 0; i < arrInts.Length; i++)
                {
                    for (int j = 1; j < arrInts.Length; j++)
                    {
                        if (i != j)
                            if (arrInts[i] == arrInts[j])
                            {
                                count++;
                                break;
                            }
                    }
                }
                return (arrInts.Length - count);
            }
            
            int DifferentNumbers (int[] arrInts)
            {
                int count = 1;
                Array.Sort(arrInts);
                for (int i = 1; i < arrInts.Length; i++)
                {
                    count++;
                    if (arr[i] == arrInts[i - 1])
                        count--;
                }
                return count;
            }

            Console.WriteLine("Equale couple " + EqualeCouple(arr));
            Console.WriteLine("Not match " + NotMatch(arr));
            Console.WriteLine("Different numbers " + DifferentNumbers(arr));
            Console.ReadKey();
      }
    }
}
