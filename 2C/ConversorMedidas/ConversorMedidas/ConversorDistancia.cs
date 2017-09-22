using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMedidas
{
    static class ConversorDistancia
    {

        public static double MparaKm(double x)
        {
            return x / 1000;
        }

        public static double KmparaM(double x)
        {
            return x * 1000;
        }

        public static double MparaCm(double x)
        {
            return x * 100;
        }

        public static double CmparaM(double x)
        {
            return x / 100;
        }

        public static double MparaPoleg(double x)
        {
            return x * 39.3701;
        }

        public static double PolegparaM(double x)
        {
            return x * 0.0254;
        }

        public static double MparaPes(double x)
        {
            return x * 3.28084;
        }

        public static double PesparaM(double x)
        {
            return x * 0.3048;
        }

        public static double KmparaCm(double x)
        {
            return x * 100000;
        }

        public static double CmparaKm(double x)
        {
            return x / 100000;
        }

        public static double KmparaPoleg(double x)
        {
            return x * 39370.1;
        }

        public static double PolegparaKm(double x)
        {
            return x * 0.0000254;
        }

        public static double KmparaPes(double x)
        {
            return x * 3280.84;
        }

        public static double PesparaKm(double x)
        {
            return x * 0.0003048;
        }

        public static double CmparaPoleg(double x)
        {
            return x * 0.393701;
        }

        public static double PolegparaCm(double x)
        {
            return x * 2.54;
        }
        public static double CmparaPes(double x)
        {
            return x * 0.0328084;
        }
        public static double PesparaCm (double x)
        {
            return x * 0.3048;
        }
        public static double PesparaPoleg(double x)
        {
            return x * 12.000;
        }
        public static double PolegparaPes(double x)
        {
            return x * 0.083333;
        }
        public static double MilhasparaKm(double x)
        {
            return x * 1.6;
        }
        public static double KmparaMilhas(double x)
        {
            return x * 0.62;
        }
    }
}
