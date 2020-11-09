using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarijableVijezbe3
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = 32, b = 24, c = 16, d = 6;
            double x = a * a + b * b + c * c + d * d / (a + b) * (a + b) + (c + d) * (c + d);
            Console.WriteLine(x);


            Console.ReadKey();        }
    }
}
