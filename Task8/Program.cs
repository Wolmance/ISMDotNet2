using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double a;
            int n;
            Console.Write("Введіть a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введіть n = ");
            n = int.Parse(Console.ReadLine());
            double q = a;
            for (int i = 1; i < n; i++)
            {
                a = a * q;
            }
            Console.WriteLine($"a = {a}");
        }
    }
}
