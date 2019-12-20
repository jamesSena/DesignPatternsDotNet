﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDotNet
{
    public class ISS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.6;
        }
    }
}
