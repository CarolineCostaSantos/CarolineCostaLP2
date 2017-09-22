using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMedidas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1- Distância | 2- Temperatura | 3- Massa");
            int r = int.Parse(Console.ReadLine());

            if (r == 1)
            {
                Console.WriteLine("Digite a distância");
                double x = double.Parse(Console.ReadLine());

                Console.WriteLine("1- M para Km | 2- Km para M");
                int c = int.Parse(Console.ReadLine());

                if (c == 1)
                {
                    Console.WriteLine("{0} m é equivalente a {1} km", x, ConversorDistancia.MparaKm(x));
                }

                else if (c == 2)
                {
                    Console.WriteLine("{0} km é equivalente a {1} m", x, ConversorDistancia.KmparaM(x));
                }
            }

            else if (r == 2)
            {
                Console.WriteLine("Digite a temperatura");
                double x = double.Parse(Console.ReadLine());

                Console.WriteLine("1- C para K | 2- K para C");
                int c = int.Parse(Console.ReadLine());

                if (c == 1)
                {
                    Console.WriteLine("{0} °c é equivalente a {0} k", x, ConversorTemperatura.CparaK(x));
                }

                else if (c == 2)
                {
                    Console.WriteLine("{0} k é equivalente a {1} °c", x, ConversorTemperatura.KparaC(x));
                }
            }

            else if (r == 3)
            {
                Console.WriteLine("Digite a massa");
                double x = double.Parse(Console.ReadLine());

                Console.WriteLine("1- G para Kg | 2- Kg para G");
                int c = int.Parse(Console.ReadLine());

                if (c == 1)
                {
                    Console.WriteLine("{0} g é equivalente a {1} kg", x,  ConversorMassa.GparaKg(x));
                }

                else if (c == 2)
                {
                    Console.WriteLine("{0} kg é equivalente a {1} g", x, ConversorMassa.KgparaG(x));
                }

            }

        }
    }
}
