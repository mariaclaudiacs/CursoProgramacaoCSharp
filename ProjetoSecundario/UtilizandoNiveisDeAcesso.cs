using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSecundario
{
    internal class UtilizandoNiveisDeAcesso
    {
        public static void Executar()
        {
            var publicVar = AcessoPublic.Nome;
            var internalVar = AcessoInternal.Nome;
            // var privateVar = AcessoPrivate.Nome;
        }
    }
}
