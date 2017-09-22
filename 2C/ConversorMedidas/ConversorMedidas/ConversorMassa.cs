using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMedidas
{
    static class ConversorMassa
    {

        public static double KgparaG(double x)
        {
            return x * 1000;
        }

        public static double GparaKg(double x)
        {
            return x / 1000;
        }

        public static double KgparaT(double x)
        {
            return x * 0.001;
        }

        public static double TparaKg(double x)
        {
            return x * 1000;
        }

        public static double KgparaLBS(double x)
        {
            return x * 2.2046;
        }

        public static double LBSparaKG(double x)
        {
            return x * 0.453593;
        }
    }
}
