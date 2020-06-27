using System;

namespace exam1
{
    class Program
    {
        /*Найти произведение элементов в каждой строке массива размером NxM, элементы которого вводятся с клавиатуры*/
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите размер матрицы");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] mas = new int[n, m];
            Random rnd = new Random();
            int rows = mas.GetUpperBound(0) + 1;
            int col = mas.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    mas[i, j] = rnd.Next(1, 5);
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
                array[i] = 1;
            int z = 1;
            for (int i = 0; i < n; i++)
            {
                z = 1;
                for (int j = 0; j < m; j++)
                {
                    z *= mas[i, j];
                }
                array[i] = z;
            }
            Console.WriteLine("********************");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].ToString() + " ");
            }
            Console.ReadKey();
        }
   
    }
}
