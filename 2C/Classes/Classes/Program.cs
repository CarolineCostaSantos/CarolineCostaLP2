using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasseNormal n = new ClasseNormal() ;

            n.x = int.Parse(Console.ReadLine());
            n.y = int.Parse(Console.ReadLine());

            Console.WriteLine("Soma: {0} - Produto: {1}", n.Soma(), n.Produto());

            ClasseMetodoEstatico m = new ClasseMetodoEstatico();

            m.extra = double.Parse(Console.ReadLine());

            Console.WriteLine("Salário fixo: {0} - Total: {1}", ClasseMetodoEstatico.SalarioF(), m.Acrescimo());
        }
    }
}
