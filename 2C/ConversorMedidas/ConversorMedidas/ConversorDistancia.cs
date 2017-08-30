using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMedidas
{
    static class ConversorDistancia
    {
        public static double x;

        public static double MparaKm()
        {
            return x / 1000;
        }

        public static double MparaHm()
        {
            return x / 100;
        }

        public static double MparaDam()
        {
            return x / 10;
        }

        public static double MparaDm()
        {
            return x * 10;
        }
    }
}
