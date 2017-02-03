using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    /// <summary>
    /// Classe responsável por manter a conexão do banco de dados um singleton
    /// </summary>
    public static class ContextoBanco //todo: corrigir erro e continuar a implementação da classe dispose na negócio
    {
        private static CorrenteDoBemEntities ContextoBancoSing;

        public static CorrenteDoBemEntities Get
        {
            get
            {
                if (ContextoBancoSing == null)
                {
                    ContextoBancoSing = new CorrenteDoBemEntities();
                }

                return ContextoBancoSing;
            }
        }
    }
}
