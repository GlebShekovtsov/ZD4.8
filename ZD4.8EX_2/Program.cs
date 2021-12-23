using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZD4._8EX_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину последовательности");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arrayLength];
            int min = int.MaxValue;

            for (int i = 0; i<array.Length; i++)
            {
                Console.WriteLine($"Введите значение {i}-ого элемента");
                int elem = Convert.ToInt32(Console.ReadLine());
                array[i] = elem;
            }
            for (int i = 0; i < array.Length; i++)
            {
               
                if(min > array[i])
                {
                    min = array[i];
                }
               
            }
            Console.WriteLine($"Минимальное число в последовательности: {min}");
            Console.ReadKey();
        }
    }
}
