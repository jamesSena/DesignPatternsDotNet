using System;

namespace DesignPatternsDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            IImposto iss = new ISS();
            IImposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(500.0);

            CalculadorDeImposto calculador = new CalculadorDeImposto();
            calculador.RealizaCalculo(orcamento, iss);
            Console.ReadKey();

        }
    }
}
