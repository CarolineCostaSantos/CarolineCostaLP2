using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNoPlano
{
    class Objeto2D
    {
        public int x;
        public int y;


        public void AndarParaD()

        {
            x = x + 3;

        }


        public void AndarParaE()
        {
            x = x - 3;
        }


        public void AndarParaC()
        {
            y = y - 3;
        }

        public void AndarParaB()
        {
            y = y + 3;
        }

        public string Cordenadas()
        {
            return string.Format("({0}, {1})", x, y);
        }
    }
}
