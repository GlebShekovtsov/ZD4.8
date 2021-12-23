using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZD4._8EX_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("Введите максимальный диапазон рандома: ");
            int rand_range = Convert.ToInt32(Console.ReadLine());
            int cpu_num = rand.Next(0, rand_range);
            string user_num;
            int tryes = 0;
            while (true)
            {
                Console.Write("\nВведите вашу отгадку: ");
                user_num = Console.ReadLine();
                tryes++;
                if (user_num=="")
                {
                    Console.WriteLine($"Задуманное число: {cpu_num}");
                    Console.ReadLine();
                    break;
                }
                if (Convert.ToInt32(user_num) > cpu_num)
                {
                    Console.WriteLine("Задуманное компьютером число меньше! Попробуйте ещё раз");
                }
                else if (Convert.ToInt32(user_num)< cpu_num)
                {
                    Console.WriteLine("Задуманное компьютером число больше! Попробуйте ещё раз");
                }

                else
                {
                    Console.WriteLine($"Вы отгадали, задуманное число: {cpu_num}, число попыток: {tryes}");
                    Console.ReadLine();
                    break;
                }
              
            }
            
        }
    }
}
