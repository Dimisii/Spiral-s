using System;

namespace Spiral
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи любое целое число. (Лучше не очень большое ;)");
            Console.WriteLine("Если ввод будет другим, вернёт ошибку и закроется.");
            int n = Convert.ToInt32(Console.ReadLine());
            int N = (int)Math.Pow(n, 2);
            int[,] matrix = new int[n, n];

            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);
            int T = n;
            int i = 0;
            int x = -1;
            int y = 0;

            for (; i < N;)
            {

                for (int c = 0; c < T; c++)
                {
                    x++;
                    i++;
                    if (x <= n - 1)
                    { matrix[y, x] = i; }
                }
                T--;
                for (int c = 0; c < T; c++)
                {
                    y++;
                    i++;
                    if (y <= n - 1)
                    { matrix[y, x] = i; }

                }
                for (int c = 0; c < T; c++)
                {
                    x--;         
                    i++;
                    if (x <= n - 1)
                    { matrix[y, x] = i; }
                }
                T--;
                for (int c = 0; c < T; c++)
                {
                    y--;
                    i++;
                    if (y <= n - 1)
                    { matrix[y, x] = i; }
                }
                
            }



            for (int c = 0; c < height; c++)
            {
                for (int z = 0; z < width; z++)
                {
                    Console.Write(matrix[c, z] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Нажми 'enter' чтобы закрыть программу.");
            Console.Read();
        }   
        }
    }

