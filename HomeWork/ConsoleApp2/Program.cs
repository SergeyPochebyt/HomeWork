using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
//    5.61. Известен рост каждого ученика двух классов.Определить средний рост уче-
//ников каждого класса.Численность обоих классов одинаковая.

    class Program
    {
        static void Main(string[] args)
        {
            Double[] HeigthClass1 = new double[5] ;
            Double[] HeigthClass2 = new double[5];
            
            Console.WriteLine("Entre heigth first class");
            for (int i = 0; i < HeigthClass1.Length; i++)
                HeigthClass1[i] = Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine("Entre heigth second class");
            for (int i = 0; i < HeigthClass1.Length; i++)
                HeigthClass2[i] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Average heigth for fierst class is " + HeigthClass1.Average());
            Console.WriteLine("Average heigth for second class is " + HeigthClass2.Average());

            Console.ReadKey();
        }
    }
}
