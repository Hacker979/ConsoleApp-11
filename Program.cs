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
        static int Max(int k, int m)
        {
            return k>m?k:m;
        }
        
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("d = ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine($"s = {Max(k,m)+Max(c,d)}");
            Console.Read();
        }
    }
}
