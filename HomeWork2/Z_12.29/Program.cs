using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_12._29
{
    //12.29.* Заполнить двумерный массив размером 7 7 числами 1, 2, ..., 49, располо-
    //женными в нем по спирали(рис. 12.5).
    //1 | 2 |
    //Рис. 12.5
    class Program
    {
        static void Main(string[] args)
        {
           
            int n = 7;
            int [,]arr = new int[n,n];
            int half = n/2;
            int num = 1;

            for (int k = 1; k <= half; k++)
            {
                for (int i = k - 1; i < n - k + 1; i++)
                {
                    arr[k - 1, i] = num++;
                }

                for (int i = k; i < n - k + 1; i++)
                {
                    arr[i, n - k] = num++;
                }

                for (int i = n - k - 1; i >= k - 1; i--)
                {
                    arr[n - k, i] = num++;
                }

                for (int i = n - k - 1; i >= k; i--)
                {
                    arr[i, k - 1] = num++;
                }
            }

            if (n % 2 != 0)
                arr[half, half] = n * n;


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    
                    Console.Write("{0, 5}", arr[i, j]);
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
