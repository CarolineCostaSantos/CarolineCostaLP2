using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class ClasseMetodoEstatico
    {
        public double extra;
        public double total = 0;

        public static int SalarioF()
        {
            int salario = 800;

            return salario;
        }

        public double Acrescimo()
        {
          return total = SalarioF() + extra;
        }
    }
}
