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
            
            Console.WriteLine("Informe a quantidade de carros no galpão");
            N = Convert.ToInt32(Console.ReadLine());

            carro[] C1 = new carro[N] ;
            string[] resul = new string[N];
                        
            for (int i = 0; i < N; i++)
            {

                Console.WriteLine("Informe o modelo");
                C1[i].modelo = Console.ReadLine();

                Console.WriteLine("Informe sua quilometragem");
                C1[i].km = Double.Parse(Console.ReadLine());

                Console.WriteLine("Informe a potência do motor");
                C1[i].mot = Double.Parse(Console.ReadLine());


                resul[i] = Classificar (C1[i]);

            }

            for (int i = 0; i<N; i++)
            {
                Console.WriteLine("{0} - {1}",C1[i].modelo, resul[i]);
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
