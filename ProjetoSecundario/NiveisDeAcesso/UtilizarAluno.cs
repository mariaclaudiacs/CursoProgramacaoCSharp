using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSecundario.NiveisDeAcesso
{
    public class UtilizarAluno
    {
        public static void Executar()
        {
            var dataNascimento = DateTime.Parse("26/08/1990");
            Aluno aluno = new Aluno("Fulaninho", "6.236.365", dataNascimento);
            Console.WriteLine(aluno.Nome);
            Console.WriteLine(aluno.Cadastro);
            //Console.WriteLine(aluno.DataNascimento);
        }
    }
}
