using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMedidas
{
    static class ConversorMassa
    {
        public static double x;


        public static double KgparaG()
        {
            return x * 1000;
        }

        public static double GparaKg()
        {
            return x / 1000;
        }

        public static double KgparaT()
        {
            return x * 0.001;
        }

        public static double TparaKg()
        {
            return x * 1000;
        }

        public static double KgparaLBS()
        {
            return x * 2.2046;
        }

        public static double LBSparaKG()
        {
            return x * 0.453593;
        }
    }
}
