using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp
{
    internal class Pessoa
    {
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public Pessoa(string nome, int idade, double peso, double altura)
        {
            Nome = nome;
            Idade = idade;
            Peso = peso;
            Altura = altura;
        }

        public string PegarCPF()
        {
            var objetoQuePegaNumeroAleatorio = new Random();
            return string.Format("{0}.{1}.{2}-{3}",
                objetoQuePegaNumeroAleatorio.Next(1, 999).ToString("D3"),
                objetoQuePegaNumeroAleatorio.Next(1, 999).ToString("D3"),
                objetoQuePegaNumeroAleatorio.Next(1, 999).ToString("D3"),
                objetoQuePegaNumeroAleatorio.Next(1, 99).ToString("D2"));
        }

        public string PegarIMC()
        {
            return (Peso / Math.Pow(Altura, 2)).ToString("F2");
        }

        public int PegarAnoNascimento()
        {
            return 2022 - Idade;
        }
    }

    public class UsarPessoa { 
        public static void Executar()
        {
            Console.WriteLine("Informe o nome.");
            string nome = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Informe a idade.");
            int idade = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Informe o peso.");
            double peso = double.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Informe a altura.");
            double altura = double.Parse(Console.ReadLine() ?? string.Empty);

            var pessoa = new Pessoa(nome, idade, peso, altura);
            Console.WriteLine($"Ano de nascimento: {pessoa.PegarAnoNascimento()}");
            Console.WriteLine($"I.M.C: {pessoa.PegarIMC()}");
            Console.WriteLine($"CPF: {pessoa.PegarCPF()}");
        }
    }
}
