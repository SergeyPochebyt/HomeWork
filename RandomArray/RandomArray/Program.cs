using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RandomArray
{
    //Заполнить одномерный массив НЕПОВТОРЯЮЩИМИСЯ целыми случайными числами
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            
            program.TestingMethods(100000);
            program.TestingMethods(300000);

            Console.ReadKey();
        }

        private void TestingMethods(int sizeArr)
        {
            Stopwatch sWatch = new Stopwatch();

            Console.WriteLine("1 - Method for " + sizeArr + " elements");
            sWatch.Start();
            int[] arrayR1 = GetArray1(sizeArr);
            sWatch.Stop();
            var time1 = sWatch.Elapsed;
            Console.WriteLine(time1);
            sWatch.Restart();

            Console.WriteLine("2 - Method for " + sizeArr + " elements");
            sWatch.Start();
            int[] arrayR2 = GetArray2(sizeArr);
            sWatch.Stop();
            var time2 = sWatch.Elapsed;
            Console.WriteLine(time2);
            sWatch.Restart();

            Console.WriteLine("3 - Method for " + sizeArr + " elememts");
            sWatch.Start();
            int[] arrayR3 = GetArray3(sizeArr);
            sWatch.Stop();
            var time3 = sWatch.Elapsed;
            Console.WriteLine(time3);
            sWatch.Restart();
        }

        private int[] GetArray1(int n)
        {
            Random rand = new Random();
            int[] arr = new int[n];
            int range = 10;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, n * range);
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[i] == arr[j])
                    {
                        i--;
                    }
                }
            }
            return arr;
        }

        private int[] GetArray2(int n)
        {
            Random rand = new Random();
            HashSet<int> hashSetR = new HashSet<int>();
            int range = 10;
            do
            {
                hashSetR.Add(rand.Next(1, n * range));
            } while (
                hashSetR.Count != n
            );
            int[] arr = hashSetR.ToArray();
            return arr;
        }

        private int[] GetArray3(int n)
        {
            Random rand = new Random();
            int range = 10;
            int[] arr = new int[n];
            List<int> listR = Enumerable.Range(1, n * range).ToList();
            for (int i = 0; i < n; i++)
            {
                int temp = rand.Next(1, listR.Count);
                arr[i] = listR[temp];
                listR.Remove(temp);
            }
            return arr;
        }
    }
}

