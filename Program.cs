using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_11
{
    /// <summary>
    /// Задача 2. Определить статический метод int Kop (int r, int k),
    /// который принимает два целых аргумента (рубли r, копейки k) и возвращает количество копеек.
    /// Используя этот метод, вычислить количество копеек при:
    /// </summary>
    /// <param name="args"></param>
    class Program
    {
        static int Kop(int r, int k)
        {
            return r * 100 + k;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Введите количество рублей:");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Введите количество копеек:");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(Kop(r,k));
            Console.Read();
        }
    }
}
