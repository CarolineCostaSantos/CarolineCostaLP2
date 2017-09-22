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

            Console.WriteLine("Qual Conversor deseja usar?: 1- Distância | 2- Temperatura | 3- Massa");
            int r = int.Parse(Console.ReadLine());

            if (r == 1)
            {
                Console.WriteLine("Digite a distância");
                ConversorDistancia.x = double.Parse(Console.ReadLine());

                Console.WriteLine("Qual conversão deseja fazer?: 1- M para Km | 2- Km para M");
                int c = int.Parse(Console.ReadLine());

                if (c == 1)
                {
                    Console.WriteLine(ConversorDistancia.MparaKm());
                }

                else if (c == 2)
                {
                    Console.WriteLine(ConversorDistancia.KmparaM());
                }
            }

            else if (r == 2)
            {
                Console.WriteLine("Digite a temperatura");
                ConversorTemperatura.x = double.Parse(Console.ReadLine());

                Console.WriteLine("Qual conversão deseja fazer?: 1- C para K | 2- K para C");
                int c = int.Parse(Console.ReadLine());

                if (c == 1)
                {
                    Console.WriteLine(ConversorTemperatura.CparaK());
                }

                else if (c == 2)
                {
                    Console.WriteLine(ConversorTemperatura.KparaC());
                }
            }

            else if (r == 3)
            {
                Console.WriteLine("Digite a massa");
                ConversorMassa.x = double.Parse(Console.ReadLine());

                Console.WriteLine("Qual conversão deseja fazer?: 1- G para Kg | 2- Kg para G");
                int c = int.Parse(Console.ReadLine());

                if (c == 1)
                {
                    Console.WriteLine(ConversorMassa.GparaKg());
                }

                else if (c == 2)
                {
                    Console.WriteLine(ConversorMassa.KgparaG());
                }

            }

        }
    }
}
