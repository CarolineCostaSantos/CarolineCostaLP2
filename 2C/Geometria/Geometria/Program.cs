using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            double Ar = 0;
            int b = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            triangulo t = new triangulo();

            Ar = t.A( b, h);

        }
    }
}
