using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDotNet
{
    class CalculadorDeImposto
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto) 
        {
            if ("ICMS".Equals(imposto))
            {
                double icms = new ICMS().Calcula(orcamento);
                Console.WriteLine(icms);
            }
            else if ("ISS".Equals(imposto))
            {
                double iss = new ISS().Calcula(orcamento);
                Console.WriteLine(iss);
            }
        }
    }
}
