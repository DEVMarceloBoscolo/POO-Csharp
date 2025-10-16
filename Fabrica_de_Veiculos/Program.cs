using Fabrica_de_Veiculos;
using System;

namespace Fabrica_de_Veiculos
{
    public class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("--- Carro Padrão (Construtor sem parâmetros) ---");           */padrao zero
           // Carro carroPadrao = new Carro();
            //Console.WriteLine(carroPadrao.ExibirInformacoes());
            //Console.WriteLine($"IPVA: R$ {carroPadrao.CalcularIPVA():F2}\n");

            Console.WriteLine("--- Carro com Marca e Modelo ---");
            Carro carroBasico = new Carro("VolkswagenE", "Gole",2025,45000.00,320.0,15.0);
            Console.WriteLine(carroBasico.ExibirInformacoes());
            Console.WriteLine($"IPVA: R$ {carroBasico.CalcularIPVA():F2}\n");

            Console.WriteLine("--- Carro Completo ---");
            Carro carroCompleto = new Carro("FordE", "Focuse", 2022, 220000.00,380.0,11.0);
            Console.WriteLine(carroCompleto.ExibirInformacoes());
            Console.WriteLine($"IPVA: R$ {carroCompleto.CalcularIPVA():F2}\n");

            Console.WriteLine("--- Carro Elétrico ---");
            CarroEletrico carroEletrico = new CarroEletrico("Tesla", "Modelo Y", 2023, 950000.00, 450.0, 8.0);
            Console.WriteLine(carroEletrico.ExibirInformacoes());
            Console.WriteLine($"IPVA: R$ {carroEletrico.CalcularIPVA():F2}\n");
        }
    }
}
