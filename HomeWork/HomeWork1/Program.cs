using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
//    5.38. "Странный муж" . Некий мужчина отправляется на работу, которая нахо-
//дится на расстоянии 1 км от дома.Дойдя до места работы, он вдруг вспомина-
//ет, что перед уходом забыл поцеловать жену, и поворачивает назад.Пройдя
//полпути, он меняет решение, посчитав, что правильнее вернуться на работу.
//Пройдя 1/3 км по направлению к работе, он вдруг осознает, что будет на-
//стоящим подлецом, если так и не поцелует жену. На этот раз, прежде чем из-
//менить мнение, он проходит 1/4 км.Так он продолжает метаться, и после N-
//этапа, пройдя 1/N км, снова меняет решение.
//Определить:
//а) на каком расстоянии от дома будет находиться мужчина после 100-го этапа
//(если допустить, что такое возможно);
//    б) какой общий путь он при этом пройдет.

    class Program
    {
        static void Main(string[] args)
        {
            double length, lengthFromHome, path;
            int count, sigh;

            length = 1;
            count = 100;
            path = 0;
            lengthFromHome = 0;
            sigh = 1;


            for (int i = 1; i <= count; i++)
            {
                lengthFromHome = lengthFromHome + (sigh * (length / i));
                sigh = -sigh;    
            }

            
            Console.WriteLine("Lengh from home: " + lengthFromHome);
            
            for (int i = 1; i <= count; i++)
                path = path + length / i;
            Console.WriteLine("Walk " + path);
            Console.ReadKey();

        }
    }
}
