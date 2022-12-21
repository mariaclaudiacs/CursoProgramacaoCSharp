/*
 * OMPORTANTE LER O LINK ABAIXO PARA MAIOR ENTENDIMENTO DA ESTRUTURA DO .NET 6.0
 * https://aka.ms/new-console-template
 */


// Comentário simples -> Utilizar // no inicio da linha.
//Console.WriteLine("Hello, Marco!");


// comentário de múltiplas linhas -> Utilizar /* para iniciar e */ para finalizar.
/*
Console.WriteLine("Hello, Marco!");
Console.WriteLine("Hello, Marco!");
*/


/*          ATALHOS PARA COMENTAR CÓDIGO
 * Comentar:    Ctrl + K + C
 * Descomentar: Ctrl + K + U
 * Mover a linha livremente: Segurar Alt + Setas
 */

//Console.WriteLine("Informe seu nome...");
//string nome = Console.ReadLine();
//Console.WriteLine("Informe seu idade...");
//string idade = Console.ReadLine();
//Console.WriteLine("Onde você nasceu?");
//string local = Console.ReadLine();

//Console.WriteLine(String.Format(@"
//Olá {0}
//que tem {1} anos
//e nasceu em {2}
//", nome, idade, local));

//AulasCSharp.Exercicios.Executar3();

//Console.WriteLine(AulasCSharp.Exercicios.TesteOut("Marco", out int qtd));
//Console.WriteLine($"Qtd caracteres: {qtd}");

//var t = 1000.23;
//var tt = 1000.23d;
//var ttt = 1000.23f;

//var helio = "25";
//int numero = int.Parse(helio);
//Console.WriteLine(numero);

//var helio2 = "25";
//int numero2 = int.Parse(helio2 ?? "");

//int numero = 0;
//var helio = "25";

//int.TryParse(helio, out numero);
//Console.WriteLine(numero);


//var caracter = 'M';
//Console.WriteLine((int)caracter);
//Console.WriteLine(char.ConvertFromUtf32(77));

// Para acessar outro projeto, é necessário adicionar uma referência.

//using ProjetoSecundario.NiveisDeAcesso;

//var dataNascimento = DateTime.Parse("26/08/1990");
//Aluno aluno = new Aluno("Fulaninho", "6.236.365", dataNascimento);
//Console.WriteLine(aluno.Nome);
// Não tenho acesso
//Console.WriteLine(aluno.Cadastro);
//Console.WriteLine(aluno.DataNascimento);

//AulasCSharp.ClassesEMetodos.Enumeradores.Executar(8);

//AulasCSharp.ClassesEMetodos.ParametrosOutERef.Executar("marco antonio angelo", out string novoNome);
//Console.WriteLine(novoNome);

//var nome = "Marco Antonio Angelo";
//Console.WriteLine(string.Empty);
//Console.WriteLine(nome);
//AulasCSharp.ClassesEMetodos.ParametrosOutERef.ExecutarDiferente(ref nome);
//Console.WriteLine(nome);


//Console.WriteLine(string.Empty);
//AulasCSharp.ClassesEMetodos.ParametrosOutERef.TryParce("XX", out double valor1);
//Console.WriteLine($"Traduzindo o valor 'XX': {valor1}");
//AulasCSharp.ClassesEMetodos.ParametrosOutERef.TryParce("150", out double valor2);
//Console.WriteLine($"Traduzindo o valor '150': {valor2}");

using AulasCSharp.ColecoesDeDados;
using AulasCSharp.Exceções;
using AulasCSharp.ExerciciosDeOO;
using AulasCSharp.Fundamentos;
using AulasCSharp.JSON;
using AulasCSharp.UtilizandoArquivos;

//var listaContas = new List<Conta>()
//            {
//                new Conta(100, 600, false),
//                new Conta(10, 100, true),
//            };

//foreach (var conta in listaContas)
//{
//    TratandoExceptions.RealizarOperacao(conta, 110, TipoOperacao.Saque);
//    TratandoExceptions.RealizarOperacao(conta, 110, TipoOperacao.Compra);
//}


//MeuPrimeiroTXT.EscreverNoArquivo("Marco");
//MeuPrimeiroTXT.LerArquivo();
//UtilizandoJSON.Executar();
ExecutarPolimorfismoEmSala.Executar();