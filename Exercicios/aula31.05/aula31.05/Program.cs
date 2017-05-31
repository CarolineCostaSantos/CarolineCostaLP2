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
 
           
                obj.x = int.Parse(Console.ReadLine());
                obj.x = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite a direção: ");
            ConsoleKey direção = Console.ReadKey().Key;

            if (direção  == ConsoleKey.RightArrow)
            {
                obj.AndarParaD;
                Console.WriteLine(obj.Cordenadas());
            }
        }
    }
}
