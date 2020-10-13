using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int a, b;
            Console.Write("Введіть a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введіть b = ");
            b = int.Parse(Console.ReadLine());
            int P = (a + b) * 2;
            int S = a * b;
            Console.WriteLine($"P = {P}");
            Console.WriteLine($"S = {S}");
        }
    }
}
