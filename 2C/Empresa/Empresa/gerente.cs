using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Gerente : Funcionario
    {
        public string Setor { get; set; }
        public double Bonus { get; set; } //porcentagem do salario

        public Gerente(string setor)
        {
            Setor = setor;
        }
    }

}