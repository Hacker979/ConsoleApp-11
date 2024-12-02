using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_11
{
    /// <summary>
    /// Задача 5. Рассчитать значение y, определив и используя статический метод:
    /// <param name="args"></param>
    class Program
    {
        static double n6()
        {
            return (((Math.Sqrt(7) + 7) / 3) + ((Math.Sqrt(11) + 11) / 3) + ((Math.Sqrt(15) + 15) / 3));
        }
        static int input(string a)
        {
            Console.Write(a);
            return int.Parse(Console.ReadLine());
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine($"y = {n6()}");
            Console.Read();
        }
    }
}
