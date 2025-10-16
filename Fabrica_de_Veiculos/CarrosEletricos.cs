using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_de_Veiculos
{
    public class CarroEletrico : Carro
    {
        private double autonomia;
        private double tempoDeRecarga;

        public CarroEletrico(string marca, string modelo, int ano, double valor, double autonomia, double tempoDeRecarga)
        {
           
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
            this.valor = valor;

         
            this.autonomia = autonomia;
            this.tempoDeRecarga = tempoDeRecarga;
        }

        public CarroEletrico()
        {
            this.marca = "Não informada";
            this.modelo = "Não informado";
            this.ano = 0;
            this.valor = 0.0;
            this.autonomia = 0.0;
            this.tempoDeRecarga = 0.0;
        }
        public CarroEletrico(string marca, string modelo, int ano, double valor, double tempoDeRecarga)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
            this.valor = valor;
            this.autonomia = 400.0; // Valor padrão
            this.tempoDeRecarga = tempoDeRecarga;
        }

        public double Autonomia { get => autonomia; set => autonomia = value; }
        public double TempoDeRecarga { get => tempoDeRecarga; set => tempoDeRecarga = value; }

        public override string ExibirInformacoes()
        {
            return $"{base.ExibirInformacoes()}, Autonomia: {autonomia}km, Tempo de Recarga: {tempoDeRecarga}h";
        }

        // Sobrescreve o método CalcularIPVA()
        public override double CalcularIPVA()
        {
            return valor * 0.02; // IPVA de 2% para carros elétricos
        }
    }

}
