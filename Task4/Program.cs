using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double a, b, c;
            Console.Write("Введіть a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введіть b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Введіть c = ");
            c = double.Parse(Console.ReadLine());
            double D = (b * b - 4 * a * c);
            if ((b * b - 4 * a * c) > 0)
            {
                double x1 = (-1 * b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                Console.WriteLine($"Перший корінь дорівнює {x1}");
                double x2 = (-1 * b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                Console.WriteLine($"Другий корінь дорівнює {x2}");
            }
            if (D == 0)
            {
                double x1 = (-1 * b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                Console.WriteLine($"Корінь дорівнює {x1}");
            }
            if (D < 0)
            {
                Console.WriteLine("Розв'язків немає");
            }





        }
    }
}
