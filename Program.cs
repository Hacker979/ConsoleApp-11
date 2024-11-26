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
            return (((Math.Sqrt(2) + 2) / (Math.Sqrt(7) + 7)) + ((Math.Sqrt(5) + 5) / (Math.Sqrt(13) + 13)) + ((Math.Sqrt(11) + 11) / (Math.Sqrt(8) + 8)));
        }
        static int input(string a)
        {
            Console.Write(a);
            return int.Parse(Console.ReadLine());
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine($"ответ: {n6()}");
            Console.Read();
        }
    }
}
