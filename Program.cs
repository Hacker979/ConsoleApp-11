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
        static int max(int a, int b, int c)
        {
            return a>b?a:b<c?c:b ;
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
            Console.WriteLine($"ответ:{max(a,b,c)}");
            Console.Read();
        }
    }
}
