using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
//    6.108. В некоторой стране используются денежные купюры достоинством в 1, 2, 4,
//8, 16, 32 и 64. Дано натуральное число n.Как наименьшим количеством та-
//ких денежных купюр можно выплатить сумму n (указать количество каждой
//из используемых для выплаты купюр)? Предполагается, что имеется доста-
//точно большое количество купюр всех достоинств.
    class Program
    {
        static void Main(string[] args)
        {
            int b1=0, b2=0, b3=0, b4=0, b5=0, b6=0, b7=0,temp=0;
            int a1 = 1;
            int a2 = 2;
            int a3 = 4;
            int a4 = 8;
            int a5 = 16;
            int a6 = 32;
            int a7 = 64;
            int n = 1000;

            temp = n % a7;

            if (temp == 0)
                b7 = n % a7;
            else
            {
                b7 = n / a7;
                n = n % a7;
                temp = n % a6;
                if (temp == 0)
                    b6 = n / a6;
                else
                {
                    b6 = n / a6;
                    n = n % a6;
                    temp = n % a5;
                    if (temp == 0)
                        b5 = n / a5;
                    else
                    {
                        b5 = n / a5;
                        temp = n % a5;
                    }
                }

            }
            
            Console.WriteLine("64 " + b7);
            Console.WriteLine("32 " + b6);
            Console.WriteLine("16 " + b5);
            Console.WriteLine("1  " + temp);
            Console.ReadKey();
        }
    }
}
