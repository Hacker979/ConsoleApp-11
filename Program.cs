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
        static void Meters(int k, int m)
        {
            Console.WriteLine($"{k*1000+m} метров");
        }
        
        static void Main(string[] args)
        {
            Meters(int.Parse( Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.Read();
        }
    }
}
