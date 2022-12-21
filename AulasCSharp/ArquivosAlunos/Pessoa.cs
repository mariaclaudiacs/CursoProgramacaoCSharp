using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp.ClassesEMetodos
{
    public class Guilherme_Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public double Imc { get; set; }

       

        public Guilherme_Pessoa(string nome, int idade, double altura, double peso)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
            Peso = peso;
        }

        public double pegarImc()
        {
            // Altura * Altura
            Imc = Peso / Math.Pow(Altura, 2);
            return Imc;
        }

        public int pegarAnoNascimento()
        {
            
            return 2022 - Idade;
        }

        public string pegarCpf()
        {
            string cpf;
            Random cpfAleatorio = new Random();
            int cpfPrimeiros = cpfAleatorio.Next(100, 999);
            int cpfSegundos = cpfAleatorio.Next(100, 999);
            int cpfTerceiros = cpfAleatorio.Next(100, 999);
            
            int cpfUltimos = cpfAleatorio.Next(10, 99);
            cpf = cpfPrimeiros + "." + cpfSegundos + "." + cpfTerceiros + "-" + cpfUltimos;
            return cpf;

        }

        
    }
}

