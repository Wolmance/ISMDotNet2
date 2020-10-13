using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double a, b, x;
            Console.Write("Введіть a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введіть b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Введіть x = ");
            x = double.Parse(Console.ReadLine());
            double y = 2.4 * (Math.Abs(Math.Pow(x, 2) + b) / a) + (a - b) * (Math.Pow(Math.Sin(a - b), 2)) + (Math.Pow(10, (-2))) * (x - b);
            Console.WriteLine($"y = {y}");
        }
    }
}
