﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNoPlano
{
        class Objeto2D
    {
       public  int x;
       public  int y;
    }

     public void AndarParaD()

     {
        x = x + 3;

     }

    public string Coorenadas()

    {
        return string.Format("({0}, {1})", x, y);
    }
} 
