using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_11
{
    /// <summary>
    /// Задача 3. Найти максимальное из трех целых чисел, используя вспомогательные методы.
    /// <param name="args"></param>
    class Program
    {
        static double max()
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
            Console.WriteLine($"ответ: {max()}");
            Console.Read();
        }
    }
}
