using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_11
{
    /// <summary>
    /// Задача 6. Рассчитать значение х, определив и используя статический метод:
    /// <param name="args"></param>
    class Program
    {
        static double n6()
        {
            return (((Math.Sqrt(8) + 15) / (Math.Sqrt(15) + 8)) + ((Math.Sqrt(12) + 6) / (Math.Sqrt(6) + 12)) + ((Math.Sqrt(21) + 7) / (Math.Sqrt(7) + 21)));
        }
        static int input(string a)
        {
            Console.Write(a);
            return int.Parse(Console.ReadLine());
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine($"x = {n6()}");
            Console.Read();
        }
    }
}
