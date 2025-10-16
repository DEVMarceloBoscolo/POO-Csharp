using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_de_Veiculos
{
    public class Carro
    {
        
        protected string marca;
        protected string modelo;
        protected int ano;
        protected double valor;

        public Carro()
        {
            this.marca = "Não informada";
            this.modelo = "Não informado";
            this.ano = 0;
            this.valor = 0.0;
        }

        public Carro(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = 0;
            this.valor = 0.0;
        }

        public Carro(string marca, string modelo, int ano, double valor)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
            this.valor = valor;
        }

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Ano { get => ano; set => ano = value; }
        public double Valor { get => valor; set => valor = value; }

        public virtual string ExibirInformacoes()
        {
            return ( $"Marca: {marca}, Modelo: {modelo}, Ano: {ano}, Valor: R$ {valor:F2}");
        }

        // Método virtual para cálculo do IPVA
        public virtual double CalcularIPVA()
        {
            return valor * 0.04; // Alíquota padrão de 4%
        }
    }



}
