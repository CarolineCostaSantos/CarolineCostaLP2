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

          
            Objeto2D obj = new Objeto2D();
 
           
            obj.x = x;
            obj.y = y;


            Console.WriteLine("Digite a direção: ");
            ConsoleKey direção = Console.ReadKey().Key;
          
            while (direção != ConsoleKey.Escape)
            { 

                if (direção  == ConsoleKey.RightArrow && obj.x + 3 <= L)
                {
                    obj.AndarParaD();
                }

                else if (direção == ConsoleKey.LeftArrow && obj.x >= 3)
                {
                    obj.AndarParaE();
                }

                else if (direção == ConsoleKey.UpArrow && obj.y >= 3)
                {
                    obj.AndarParaC();
                }

                else if (direção == ConsoleKey.DownArrow && obj.y + 3 <= A)
                {
                    obj.AndarParaB();
                }


                Console.WriteLine("Digite a direção: ");
                direção = Console.ReadKey().Key;
                Console.WriteLine(obj.Cordenadas());
            }
        }
        
        
    }
}
