using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMedidas
{
      static  class ConversorTemperatura
    {

          public static double KparaC(double x)
          {
              return x - 273;
          }
          public static double CparaK(double x)
          {
              return x + 273;
          }
          public static double kparaF(double x)
          {
              return 1.8 * (x - 273) + 32;
          }
          public static double FparaK(double x)
          {
            return (x + 459.67) * 5 / 9;
          }
          public static double FparaC(double x)
          {
              return (x - 32) / 1.8;
          }
          public static double CparaF(double x)
          {
              return (x * 1.8) + 32;
          }
      }
    }

