using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Terceirizado : Empregado
    {

        public string EmpresaMatriz { get; set; }


        public Terceirizado(string nome, int data, string empresaM) : base(nome, data)
        {
           EmpresaMatriz = empresaM;
        }
    }
}
