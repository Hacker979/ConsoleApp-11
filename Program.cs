using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_11
{
    /// <summary>
    /// Задача 1. Определить статический метод int Meters (int k, int m),
    /// который принимает два целых аргумента (километры k, метры m) и возвращает количество метров.
    /// Используя этот метод, вычислить количество метров для расстояния:
    /// </summary>
    /// <param name="args"></param>
    class Program
    {
        static int Meters(int k, int m)
        {
            return k * 1000 + m;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Введите километры:");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Введите метры:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine(Meters(k,m));
            Console.Read();
        }
    }
}
