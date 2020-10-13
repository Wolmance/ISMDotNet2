using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double n;
            Console.Write("Введіть n = ");
            n = double.Parse(Console.ReadLine());
            double S = 1;
            for (int i = 1; i <= n; i++)
            {
                S = S + 1/i;
            }
            Console.WriteLine($"S = {S}");
        }
    }
}
