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

        public static double KmparaM()
        {
            return x * 1000;
        }

        public static double MparaCm()
        {
            return x * 100;
        }

        public static double CmparaM()
        {
            return x / 100;
        }

        public static double MparaPoleg()
        {
            return x * 39.3701;
        }

        public static double PolegparaM()
        {
            return x * 0.0254;
        }

        public static double MparaPes()
        {
            return x * 3.28084;
        }

        public static double PesparaM()
        {
            return x * 0.3048;
        }

        public static double KmparaCm()
        {
            return x * 100000;
        }

        public static double CmparaKm()
        {
            return x / 100000;
        }

        public static double KmparaPoleg()
        {
            return x * 39370.1;
        }

        public static double PolegparaKm()
        {
            return x * 0.0000254;
        }

        public static double KmparaPes()
        {
            return x * 3280.84;
        }

        public static double PesparaKm()
        {
            return x * 0.0003048;
        }
    }
}
