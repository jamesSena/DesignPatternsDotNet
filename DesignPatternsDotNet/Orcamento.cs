namespace DesignPatternsDotNet
{
    public class Orcamento
    {
        public Orcamento(double valor) => Valor = valor;  
        public double Valor { get; internal set; }
    }
}