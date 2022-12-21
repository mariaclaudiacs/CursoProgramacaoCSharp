using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp
{
    internal class Exercicios
    {
        const int QTD_REPETICOES = 10;

        public static void Executar3()
        {
            Console.WriteLine("Informe seu nome...");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe seu idade...");
            string idade = Console.ReadLine();
            Console.WriteLine("Onde você nasceu?");
            string local = Console.ReadLine();

            Console.WriteLine(String.Format(@"
            Olá {0}
            que tem {1} anos
            e nasceu em {2}
            ", nome, idade, local));
        }

        public static void Executar2()
        {
            Console.Write("Texto diferente!");
        }

        public static void Executar()
        {
            // Dá erro por começar com número ou caracter especial
            //string 1koc = string.Empty;
            //string t-0 = string.Empty;

            string t_0 = string.Empty;
            string var1 = string.Empty;

            t_0 = "Texto";
            var1 = "Texto";

            // Dá erro por dr tratar do mesmo nome
            //if (true)
            //{
            //    string var1 = "Texto";
            //}

            //bool boleano = null;
            bool? boleano = null;

            //// Dá erro
            //boleano.ToString();

            string valor = boleano?.ToString() ?? "";
            bool boleano2 = boleano ?? false;
        }

        public static string TesteOut(string entrada, out int numeroCarateres)
        {
            numeroCarateres = entrada.Length;
            return entrada.ToUpper();
        }
    }
}
