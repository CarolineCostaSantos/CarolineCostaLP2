using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{   
    class Empregado: Funcionario
    {
       private string dEntrada;
       public Gerente gerente {get; set;}


       public string DEntrada
       {
           get { return dEntrada; }
       }

        public Empregado(string nome, string Data): base(nome)
       {
           dEntrada = Data;
       }

    }
}
