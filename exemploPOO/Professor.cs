using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploPOO
{
    //exemplo da implementação da herança
    public class Professor : Pessoa
    {
        //atributos de classe
        public string disciplina { get; set; }
        public string escola { get; private set; }

        // ex de metodo construtor
        public Professor(string escola)
        {
            this .escola = escola;

        }

        //exemplo de método void = sem retorno de valor (executa uma ação)
        public virtual void chamarAluno()
        {
            Console.WriteLine($"Boara para aula!! alunos do {escola}");
        }

        //método com retorno é tipo double e recebe 3 parametros do tipo double
        public double calcularMedia(double nota1, double nota2, double nota3)
        {
            //variavel
            double media = (nota1 + nota2 + nota3) / 3;
            return media;
        }

        //metodo de sobrecarga
        public double calcularMedia(double nota1, double nota2)
        {
            double media = (nota1 + nota2) / 2;
            return media;
        }



        public override void mostraNome()
        {
            Console.WriteLine("Professor: ");
            Console.WriteLine($"Nome: {this.getNome()}");
        }
    }
}
