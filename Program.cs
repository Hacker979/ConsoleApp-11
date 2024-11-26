using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_11
{
    /// <summary>
    /// Задача 2. Определить статический метод int Seconds (int h, int m, int s),
    /// который принимает три целых аргумента (часы h, минуты m и секунды s) и возвращает количество секунд, прошедших с начала дня.
    /// Используя этот метод, вычислить количество секунд, прошедших с начала дня при:
    /// </summary>
    /// <param name="args"></param>
    class Program
    {
        static int Second(int h, int m, int s)
        {
            return h*3600 + m*60 + s;
        }
        static int input(string a)
        {
            Console.Write(a);
            return int.Parse(Console.ReadLine());
        }
        
        static void Main(string[] args)
        {
            int h = input("Введите часы: ");
            int m = input("Введите минуты: ");
            int s = input("Введите сеунды: ");
            Console.WriteLine($"{Second(h,m,s)} секунд");
            Console.Read();
        }
    }
}
