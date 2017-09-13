using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{   
    class Empregado: Funcionario
    {
       private  int dEntrada;
       public Gerente gerente {get; set;}


       public int DEntrada
       {
           get { return dEntrada; }
       }

        public Empregado(string nome, int Data): base(nome)
       {
           dEntrada = Data;
       }

    }
}
