using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPessoa
{
    public class Pessoa
    {
        public string Nome = string.Empty;
        public int Idade;
        public double Altura;
        public double Peso;

        public string PegarCPF()
        {
            var random = new Random();

            var g1 = random.Next(0, 9);
            var g2 = random.Next(0, 9);
            var g3 = random.Next(0, 9);
            var g4 = random.Next(0, 9);
            var g5 = random.Next(0, 9);
            var g6 = random.Next(0, 9);
            var g7 = random.Next(0, 9);
            var g8 = random.Next(0, 9);
            var g9 = random.Next(0, 9);
            var g10 = random.Next(0, 9);
            var g11 = random.Next(0, 9);

            return $"{g1}{g2}{g3}.{g4}{g5}{g6}.{g7}{g8}{g9}-{g10}{g11}";
        }

        public string PegarIMC(double peso, double altura)
        {
            double imc = peso / Math.Pow(altura, 2);
            return imc.ToString("F2");
        }

        public int PegarAnoNascimento(int Idade)
        {
            return 2022 - Idade;
        }
        internal class Metodos
        {
            public static void Executar()
            {
                var pessoa = new Pessoa();

                Console.WriteLine("Digite seu nome:");
                pessoa.Nome = Console.ReadLine();

                Console.WriteLine("Digite sua idade:");
                pessoa.Idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite sua altura:");
                pessoa.Altura = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite sua peso:");
                pessoa.Peso = double.Parse(Console.ReadLine());

                Console.WriteLine($"Seu CPF é: {pessoa.PegarCPF()}!");

                Console.WriteLine("Seu IMC é:");
                Console.WriteLine(pessoa.PegarIMC(pessoa.Peso, pessoa.Altura));

                Console.WriteLine("Seu ano de nascimento é: ");
                Console.WriteLine(pessoa.PegarAnoNascimento(pessoa.Idade));
            }
        }
    }
}
