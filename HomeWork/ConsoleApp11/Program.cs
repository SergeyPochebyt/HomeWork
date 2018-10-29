using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    //7.1. Вывести на экран все целые числа от 100 до 200, кратные трем.

    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 100;
            int n2 = 200;
            
            void KratnoeN_K (int n, int k)
            {
                if (n % k == 0)
                    Console.WriteLine(n + " kratono " + k);
                
            }

            for (int i = n1; i <= n2; i++)
                KratnoeN_K(i, 3);

            Console.ReadKey();
        }
    }
}
