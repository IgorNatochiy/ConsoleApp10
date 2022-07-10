using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число N: ");
            uint N;
            while (!uint.TryParse(Console.ReadLine(), out N) || N == 0)
                Console.Write("Ошибка! Повторите ввод: ");
            Console.WriteLine("Квадраты чисел от 1 до {0}:", N);
            for (uint i = 1, sqr = 0; i <= N; i++)
                Console.WriteLine("{0}^2 = {1}", i, sqr += i * 2 - 1);
            Console.ReadKey();
        }
    }
}
