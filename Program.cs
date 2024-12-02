using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_11
{
    /// <summary>
    /// Задача 4. Рассчитать значение z=min(2a,b+a)+min(2a-b,b),
    /// определив и используя функцию Min(x,y) – минимальное из двух чисел.
    /// <summary>
    /// <param name="args"></param>
    class Program
    {
        static int Min(int x, int y)
        {
            return x < y ? x : y;
        }

        static int Input(string a)
        {
            Console.Write(a);
            return int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int a = Input("Введите a: ");
            int b = Input("Введите b: ");
            int z = Min(2 * a, b + a) + Min(2 * a - b, b);
            Console.WriteLine($"Ответ: {z}");
            Console.ReadLine();
        }
    }
}
