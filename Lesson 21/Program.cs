using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lesson_21
{
    internal class Program
    {
        const int n = 10;
        const int m = 10;
        static int[,] path = new int[n, m] { 10, 2, 3, 8, 9, 50, 60, 100, 4, 0 };
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Gardner1);
            Thread thread = new Thread(threadStart);
            thread.Start();

            Gardner2();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{path[i, j]}");
                }
            }
           
            Console.ReadKey();
        }

        static void Gardner1()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (path[i,j] >= 0)
                    { 
                    int delay = path[i,j];
                        path[i, j] = -1;
                        Thread.Sleep(delay);
                    }
                }

            }

        }

        static void Gardner2()
        {
            for (int i = n-1; i >= 0; i--)
            {
                for (int j = n-1; j >=0; j--)
                {
                    if (path[i, j] >= 0)
                    {
                        int delay = path[i, j];
                        path[i, j] = -2;
                        Thread.Sleep(delay);
                    }
                }

            }

        }
    }
}



    