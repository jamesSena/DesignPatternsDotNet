using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDotNet
{
    class CalculadorDeImposto
    {
        public void RealizaCalculo(Orcamento orcamento, string imposto) 
        {
            if ("ICMS".Equals(imposto))
            {
                double icms = new ICMS().CalculaICSM(orcamento);
                Console.WriteLine(icms);
            }
            else if ("ISS".Equals(imposto))
            {
                double iss = new ISS().CalculaISS(orcamento);
                Console.WriteLine(iss);
            }
        }
    }
}
