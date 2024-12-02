using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_11
{
    /// <summary>
    /// Задача 1. Определить статический метод int Centimeters (int m, int c),
    /// который принимает два целых аргумента (метры m, сантиметры c) и возвращает количество сантиметров. Используя этот метод,
    /// вычислить количество сантиметров для длины:
    /// </summary>
    /// <param name="args"></param>
    class Program
    {
        static int Meters(int m, int c)
        {
            return m * 100 + c;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Введите метры:");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите сантиметры:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(Meters(m,c));
            Console.Read();
        }
    }
}
