using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_11
{
    /// <summary>
    /// Задача 3. Найти минимальное из трех целых чисел, используя вспомогательные методы.
    /// <summary>
    /// <param name="args"></param>
    class Program
    {
        static int Min2(int x, int y)
        {
            return x < y ? x : y;
        }

        static int Min3(int a, int b, int c)
        {
            return Min2(Min2(a, b), c);
        }

        static int input(string a)
        {
            Console.Write(a);
            return int.Parse(Console.ReadLine());
        }
        
        static void Main(string[] args)
        {
            int a = input("Введите a: ");
            int b = input("Введите b: ");
            int c = input("Введите c: ");
            Console.WriteLine($"ответ:{Min3(a,b,c)}");
            Console.Read();
        }
    }
}
