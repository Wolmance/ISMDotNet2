using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
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
            int D = 1;
            for ( ; a <= b; a++)
            {
                D = D * a;
            }
            Console.WriteLine($"D = {D}");
        }
     }
}

