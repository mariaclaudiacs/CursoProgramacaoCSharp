using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp
{
    internal class Pessoa_220822
    {
        string Nome {get;set;}
        string Idade { get; set; }

        public Pessoa_220822(string nome, string idade)
        {
            Nome = nome;
            Idade = idade;
        }

        internal void ImprimirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
        }
    }
}
