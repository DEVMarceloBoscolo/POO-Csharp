using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploPOO
{
    public class Aluno : Pessoa
    {
        private string materia;
        private double nota1;
        private double nota2;
        private double nota3;

        // forma simples de travar e bloquer algo {get; set;}
        //ex  public string disciplina {get; set;}

        public double Nota1 
        {
            get {return nota1;}
            set 
            {
                if (value > 0 || value < 10)
                {
                    value = nota1;
                }
            }
        }

        public double Nota2
        {
            get {return nota2;}
            set 
            {
                if (value > 0 || value < 10)
                {
                    value = nota2;
                }
            }
        }

        public double Nota3
        {
            get {return nota3;}
            set 
            {
                if(value > 0 || value < 10)
                {
                    value = nota3;
                }
            }
        }



        //criacao de propriedade.
        public string Materia 
        { 
            get { return materia; }
            set { materia = value; }
        }

        public double calcularMedia()
        {
            double media = (nota1 + nota2 + nota3) / 3;
            return media;
        }

        public override void mostraNome()
        {
            Console.WriteLine("Aluno: ");
            Console.WriteLine($"Nome: {this.getNome()}");
        }
    }
}
