namespace ProjetoSecundario
{
    public class AcessoPublic
    {
        public static string Nome { get; set; }
    }
    internal class AcessoInternal
    {
        public static string Nome { get; internal set; }
    }
    /* private */ class AcessoPrivate
    {
        // Define o nível no início
        private static string Nome { get; set; }

        // Define o nível nos métodos de get ou set.
        // public static string Nome { get; private set; }
    }
}