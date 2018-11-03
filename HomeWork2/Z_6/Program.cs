using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_6
{
    //Заполнить одномерный массив НЕПОВТОРЯЮЩИМИСЯ целыми случайными числами
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 20);
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[i] == arr[j])
                    {
                        i-- ;
                    }
                }
            }

            Console.WriteLine("Array is:");
            foreach (var i in arr)
            {
                Console.Write(" " + i + " ");
            }

            Console.ReadKey();
        }

    }
}
