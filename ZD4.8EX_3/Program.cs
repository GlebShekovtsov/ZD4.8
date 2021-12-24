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
            int randRange = Convert.ToInt32(Console.ReadLine());
            int cpuNum = rand.Next(0, randRange);
            string userNum;
            int tryes = 0;
            while (true)
            {
                Console.Write("\nВведите вашу отгадку: ");
                userNum = Console.ReadLine();
                tryes++;
                if (userNum == "")
                {
                    Console.WriteLine($"Задуманное число: {cpuNum}");
                    Console.ReadLine();
                    break;
                }
                if (Convert.ToInt32(userNum) > cpuNum)
                {
                    Console.WriteLine("Задуманное компьютером число меньше! Попробуйте ещё раз");
                }
                else if (Convert.ToInt32(userNum) < cpuNum)
                {
                    Console.WriteLine("Задуманное компьютером число больше! Попробуйте ещё раз");
                }

                else
                {
                    Console.WriteLine($"Вы отгадали, задуманное число: {cpuNum}, число попыток: {tryes}");
                    Console.ReadLine();
                    break;
                }
              
            }
            
        }
    }
}
