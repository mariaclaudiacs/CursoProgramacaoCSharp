using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSecundario.NiveisDeAcesso
{
    public class Aluno
    {
        public string Nome { get; set; }

        internal string Cadastro { get; set; } = "Cad_001";

        // tipo que armazena data
        private DateTime DataNascimento { get; set; }
        private string RG {get;set;}

        public Aluno(string nome, string rg, DateTime dataNascimento)
        {
            Nome = nome;
            RG = rg;
            DataNascimento = dataNascimento;
        }

        internal string VerificarDadosCadastro()
        {
            var sb = new StringBuilder();

            sb.AppendLine("=-=-=-=-=-=-=-=-=-=-=-=-=");
            sb.AppendLine("     Dados do aluno      ");
            sb.AppendLine("=-=-=-=-=-=-=-=-=-=-=-=-=");
            sb.AppendLine($"Nome: {Nome}");
            sb.AppendLine($"Data de Nascimento: {DataNascimento.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"RG: {RG}");
            sb.AppendLine($"Cadastro: {Cadastro}");

            return sb.ToString();
        }
    }
}
