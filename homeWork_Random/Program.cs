using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int lowerLimitRandom = 0;
            int upperLimitRandom = 101;
            int number = random.Next(lowerLimitRandom, upperLimitRandom);
            int sumNumbers = 0;
            int firstDivider = 3;
            int secondDivider = 5;

            Console.WriteLine("Рандомное число: " + number);

            for (int i = 0; i <= number; i++) 
            {
                if (((i % firstDivider) == 0) || ((i % secondDivider) == 0))
                {
                    sumNumbers += i;
                }
            }

            Console.WriteLine($"Сумма всех пложительных чисел кратных 3 или 5 до {number}(включаяя само число), равно {sumNumbers}");
            Console.ReadKey();
        }
    }
}
