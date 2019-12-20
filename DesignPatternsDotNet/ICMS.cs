using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDotNet
{
    public class ICMS : IImposto
    { 
        public double Calcula(Orcamento orcamento) 
        {
            return orcamento.Valor * 0.1;
        }
    }
}
