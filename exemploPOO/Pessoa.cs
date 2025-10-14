using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploPOO
{
    public abstract class Pessoa
    {
        // Atributos

        private string nome;

        private int idade;

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            if (nome != "" && nome != null)
            {
                this.nome = nome;
            }
            
        }

        public int getIdade()
        {
            return idade;
        }
        
        public void setIdade(int idade)
        {
            if (idade > 0) { 
                this.idade = idade;
            }
        }

        //métodos

        public void anoNasc()
        {
            int ano = 2025 - idade;
            Console.WriteLine($"{nome} você nasceu no ano de {ano}");
        }
        //exemplo de método abstrato
        public abstract void mostraNome();
    }
}
