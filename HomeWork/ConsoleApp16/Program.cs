using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
//    6.51. Дано натуральное число.Выяснить, является ли оно палиндромом("перевер-
//тышем"), т. е. числом, десятичная запись которого читается одинаково слева
//направо и справа налево.
    class Program
    {
        static void Main(string[] args)
        {
            int n = 12321;

            bool IsPalindrom (int num)
                {
                string str = num.ToString();
                char[] arr = str.ToCharArray();
                Array.Reverse(arr);
                string srt1 = new string(arr);
                if (str == srt1)
                    return true;
                else
                    return false;
                 }

            Console.WriteLine(n + " is palindrom - " + IsPalindrom(n));
            Console.ReadKey();

        }
    }
}
