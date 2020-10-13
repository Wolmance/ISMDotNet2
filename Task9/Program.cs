using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int n;
            Console.Write("Введіть n = ");
            n = int.Parse(Console.ReadLine());
            double q = 1;
            for (int i = 1; i <= n; i++)
            {
                q *= i;
            }
            Console.WriteLine($"Факторіал = {q}");
        }
    }
}
