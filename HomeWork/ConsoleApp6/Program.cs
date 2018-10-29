using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    //6.30. Дано натуральное число.Определить номер цифры 8 в нем, считая от конца числа.Если такой цифры нет, ответом должно быть число 0, если таких цифр в числе несколько — должен быть определен номер самой левой из них.
    class Program
    {
        static void Main(string[] args)
        {
            int Num = 458583;
            string str;
            str = Convert.ToString(Num);
            int n = str.LastIndexOf("8");
            if (n == 0)
                Console.WriteLine("no 8 in number " + Num);
            else
                Console.WriteLine((n + 1) + " position 8 in number " + Num);
            Console.ReadKey();

        }
    }
}
