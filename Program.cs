// See https://aka.ms/new-console-template for more information
using DesignPatterns;


public class Program
{
     static void Main(string[] args)
    {
                
            Imposto iss = new ISS();
            Imposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(5000.0);
            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

        calculador.RealizaCalculo(orcamento, icms);
        calculador.RealizaCalculo(orcamento, iss);
        Console.ReadKey();

        
    }
}