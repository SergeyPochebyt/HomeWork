using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_4
{
    //Дан массив чисел.выяснить, является ли он палиндромом(читается одинаково слева направо и справа налево)
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new[] {1, 2, 3, 4, 5, 5, 4, 3, 2, 1};

            bool IsPalindrom(int[] arrInts)
            {
                for (int i = 0; i < arrInts.Length/2; i++)
                {
                    if (arrInts[i] != arrInts[arrInts.Length - 1 - i])
                        return false;
                }
                return true;
            }

            foreach (var i in arr)
            {
                Console.Write(" " + i + " ");
            }

            Console.WriteLine();
            Console.WriteLine(IsPalindrom(arr));
            Console.ReadKey();
        }
    }
}
