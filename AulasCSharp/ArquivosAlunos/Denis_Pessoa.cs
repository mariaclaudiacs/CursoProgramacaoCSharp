//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AulasCSharp.Atividade
//{
//    internal class Denis_Pessoa
//    {
        
//        private int Idade;
//        private double Altura;
//        private int Peso;

//        public Denis_Pessoa(int idade, double altura, int peso)
//        {
            
//            Idade = idade;
//            Altura = altura;
//            Peso = peso;
//        }


//        public string Cpf()
//        {

//            var gerarcpf  = new Random().Next(100,999);
//            var gerarcpf2 = new Random().Next(100,999);
//            var gerarcpf3 = new Random().Next(100,999);
//            var gerarcpf4 = new Random().Next(10,99);
           

//            return string.Format("{0}.{1}.{2}-{3}", gerarcpf, gerarcpf2, gerarcpf3, gerarcpf4);

//        }


//        // Isso executa dentro de uma pessoa.
//        public double IMC()
//        {
//            // Vem de outra pessoa.
//           var Pessoa = new Denis_Pessoa(0,0,0);
//            var Imc = peso / Math.Pow(altura, 2);
            
//            return Imc;




//        }
//        public int PegarAnoNascimento()
//        {
//            var Nascimento = new Denis_Pessoa( 0, 0, 0);
//            var Ano = 2022- idade;
//            return Ano;

//        }

//        public static void Executar()
//        {
//           Console.WriteLine("Informe seu Nome");
//           string nome = Console.ReadLine()??"";
//           Console.WriteLine("Informe Sua Idade");
//            var idade = int.Parse(Console.ReadLine());
//            Console.WriteLine("Informe Seu Peso");
//            var peso = int.Parse(Console.ReadLine());
//            Console.WriteLine("Informe Sua Altura");
//            double altura = double.Parse(Console.ReadLine());
//            var pessoa = new Denis_Pessoa(idade, altura, peso);
//            //CPF
//            string resultadocpf;
//            var CalculoCpf = new Denis_Pessoa( 0, 0, 0);
//            resultadocpf = pessoa.Cpf();
//            Console.WriteLine(resultadocpf);

//            //IMC
//            double resultadoimc;
//            var CalculoImc = new Denis_Pessoa( 0, 0, 0 );
//            resultadoimc = pessoa.IMC(peso ,altura);
            
//           Console.WriteLine(resultadoimc);

//            //Ano Nascimento
//            int resultadonascimento;
//            var calculonascimento = pessoa.PegarAnoNascimento(idade);
//            Console.WriteLine($"{calculonascimento}");
            
//        }



//    }
//}
