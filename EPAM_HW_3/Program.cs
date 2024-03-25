using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_HW_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Просим пользователя ввести значение от 1 до 1 милиарда
            Console.Write("Enter a number from 1 to 1 Billion: ");
            int number = int.Parse(Console.ReadLine());

            // Инициализиируем переменную для накопления суммы цифр
            int sum = 0;

            // Если number <= 1E9 выполняеться итерация цикла пока number != 0 не станет true
            if (number <= 1E9)
            {
                for (; number != 0; number /= 10)
                {
                    sum += number % 10;
                }
                Console.WriteLine($"Sum of all digits in a number: {sum}");
            }
            // Если число больше 1 милиарда, выдаст соответствующее сообщение
            else
            {
                Console.WriteLine("Number over 1 billion");
            }
        }
    }
}
