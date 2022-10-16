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
            Random rand = new Random();
            int number = rand.Next(0, 101);
            int sumNumbers = number;

            Console.WriteLine("Рандомное число: " + number);

            for (int i = 0; i < number; i++) 
            {
                if ((i % 5) == 0)
                {
                    sumNumbers += i;
                }
                else if ((i % 3) == 0) 
                {
                    sumNumbers += i;
                }
            }
            Console.WriteLine("Сумма всех пложительных чисел кратных 3 или 5 до " + number +"(включаяя само число), равно " + sumNumbers);
            Console.ReadKey();
        }
    }
}
