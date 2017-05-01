using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        struct carro
            {
              public string modelo;
              public double km;
              public double mot;
            }

        static void Main(string[] args)
        {
            int N;
            string sub;
            carro C1;
            
            Console.WriteLine("Informe a quantidade de carros no galpão");
            N = Convert.ToInt32(Console.ReadLine());
                        
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Informe o modelo");
                C1.modelo = Console.ReadLine();

                Console.WriteLine("Informe sua quilometragem");
                C1.km = Double.Parse(Console.ReadLine());

                Console.WriteLine("Informe a potência do motor");
                C1.mot = Double.Parse(Console.ReadLine());


                sub = Classificar (C1);

                Console.WriteLine("{0} - {1}",C1.modelo, sub);
            
            }

        }

        
        static string Classificar(carro C1)
        {

            string tipo, tipod;


            if (C1.km <= 5000)
            {
               tipo = "novo";
            }

            else if (C1.km > 5000 && C1.km <= 30000)
            {
               tipo = "seminovo";
            }

            else
            {
               tipo = "velho";
            }              
                
            if (C1.mot > 200)
            {
               tipod = "potente";
            }

            else if (C1.mot >= 120 && C1.mot <= 200)
            {
               tipod = "forte";
            }

            else
            {
               tipod = "popular";
            }               

            return tipo + " - " + tipod;

            

        }







        
    }
}
