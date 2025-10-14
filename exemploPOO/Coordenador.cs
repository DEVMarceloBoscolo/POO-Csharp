using System;

namespace exemploPOO
{
    public class Coordenador : Professor
    {
        // sobrecarga de construtor ******************
        public Coordenador(string escola ) : base ( escola )
        {

        }

        public Coordenador(string escola, string disciplina) : base ( escola)
        {
            this.disciplina = disciplina;
        }

        // ex de sobrescrita de metodos

        public override void mostraNome()
        {
            Console.WriteLine("Coordenador: ");
            Console.WriteLine($"Nome do Coordenador de {this.disciplina}: {this.getNome()}");
        }
        public override void chamarAluno()
        {
            Console.WriteLine($"BORA PARA A AULA !!! ALUNOS DO {escola} TO MANDANDO!!");
        }

    }

}
