
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZD4._8EX_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Введите количество строк");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[row, column];
            int sum = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = rand.Next(1, 20);
                    sum += matrix[i, j];
                    Console.Write($"{matrix[i, j],4} ");
                }
                Console.WriteLine();
            }
           
            Console.WriteLine($"Сумма элементов: {sum}");
            Console.ReadLine();
        }
    }
}
