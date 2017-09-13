using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMedidas
{
      static  class ConversorDeTemperatura
    {
          public static double k;
          public static double c;
          public static double f;
          public static double KelvinparaCelsius()
          {
              return k  = c + 273;
          }
          public static double CelsiusparaKelvin()
          {
              return c = k - 273;
          }
          public static double kelvinparaFahrenheit()
          {
              return f  = 1.8 * (k - 273) + 32;
          }
          public static double FahrenheitparaKelvin()
          {
              return 
           }
         public static double FahrenheitparaCelsius()
          {
              return f = (c * 9 / 5) + 32;
          }
          public static double CelsiusparaFahrenheit()
          {
              return c = (f - 32) * 9 / 5;
          }
      }
    }
}
