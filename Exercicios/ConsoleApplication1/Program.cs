using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            string modelo,tipo,tipod;
            double km,mot;
            
            Console.WriteLine("Informe a quantidade de carros no galpão");
            N = Convert.ToInt32(Console.ReadLine());
                        
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Informe o modelo");
                modelo = Console.ReadLine();

                Console.WriteLine("Informe sua quilometragem");
                km = Double.Parse(Console.ReadLine());

                Console.WriteLine("Informe a potência do motor");
                mot = Double.Parse(Console.ReadLine());

                if (km <= 5000)
                {
                    tipo = "novo";
                }
                else if (km > 5000 && km <= 30000)
                {
                    tipo = "seminovo";
                }
                else
                {
                    tipo = "velho";
                }              
                
                if (mot > 200)
                {
                    tipod = "potente";
                }
                else if (mot >= 120 && mot <= 200)
                {
                    tipod = "forte";
                }
                else
                {
                    tipod = "popular";
                }               

                Console.WriteLine("{0} - {1} {2}", modelo, tipo, tipod);
            }

        }
    }
}
