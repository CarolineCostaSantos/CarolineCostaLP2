using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNoPlano
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 600, L = 800;

            Console.WriteLine("Digite o X inicial:  ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o y inicial:  ");
            int y = int.Parse(Console.ReadLine());

          
            Objeto2D obj = new Objeto2D;
 
           
                obj.x = x;
                obj.y = y;


            Console.WriteLine("Digite a direção: ");
            ConsoleKey direção = Console.ReadKey().Key;
          
            if (direção != ConsoleKey.Escape)
            { 

             if (direção  == ConsoleKey.RightArrow)
             {
                obj.AndarParaD();

                Console.WriteLine(obj.Cordenadas());
             }

             else if (direção == ConsoleKey.LeftArrow)
             {
                obj.AndarParaE();

                Console.WriteLine(obj.Cordenadas());
             }

             else if (direção == ConsoleKey.UpArrow)
             {
                obj.AndarParaC();

                Console.WriteLine(obj.Cordenadas());
             }

             else if (direção == ConsoleKey.DownArrow)
             {
                obj.AndarParaB();

                Console.WriteLine(obj.Cordenadas());
             }


                Console.WriteLine("Digite a direção: ");
                direção = Console.ReadKey().Key;
            }
        }
        
        
    }
}
