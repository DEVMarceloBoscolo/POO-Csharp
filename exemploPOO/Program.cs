using System;

namespace exemploPOO
{
    public class Program
    {

        static void Main(string[] args)
        {
            
            Professor pro = new Professor("Senai");
            pro.setNome("Marcelo Boscolo");
            pro.setIdade(27);
            pro.disciplina = "Matemática";
           // pro.escola = "SENAI";
            Console.WriteLine("dados Professor: ");
            pro.mostraNome();
            pro.anoNasc();
            Console.WriteLine("Disciplina "+pro.disciplina);
            pro.chamarAluno();
            Console.WriteLine($"Média: {pro.calcularMedia(8,9,10)}");


            Aluno a = new Aluno();
            a.setNome("Marcelo Carril");
            a.setIdade(14);
            a.Nota1 = 8;
            a.Nota2 = 9;
            a.Nota3 = 7;
            a.Materia = "Programção com C#";
            Console.WriteLine("dados Aluno: ");
            a.mostraNome();
            a.anoNasc();
            Console.WriteLine($"{a.getNome()} a sua nota em {a.Materia} é: {a.calcularMedia()}");

            Coordenador c1 = new Coordenador("SENAI","Curso de Java");
            c1.setNome("\n CARLOS");
            c1.setIdade(56);
            c1.anoNasc();
            c1.chamarAluno();

            Coordenador c2 = new Coordenador("SENAI", "CURSO DE C#");
            c2.setNome("\n Roberto");
            c2.setIdade( 43);
            c2.anoNasc();
            c2.chamarAluno();


        }
    }

}
