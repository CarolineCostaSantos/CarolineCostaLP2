using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMedidas
{
      static  class ConversorTemperatura
    {
        public static double x;

          public static double KparaC()
          {
              return x - 273;
          }
          public static double CparaK()
          {
              return x + 273;
          }
          public static double kparaF()
          {
              return 1.8 * (x - 273) + 32;
          }
          public static double FparaK()
          {
            return (x + 459.67) * 5 / 9;
          }
          public static double FparaC()
          {
              return (x - 32) / 1.8;
          }
          public static double CparaF()
          {
              return (x * 1.8) + 32;
          }
      }
    }

