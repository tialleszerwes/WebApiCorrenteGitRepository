using Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;

namespace Repositorio
{
    public class PedidoAjudaRep : DbContext
    {
        public PedidoAjudaRep() : base("name=PedidoAjuda")
        {

            Contexto = ContextoBanco.Get;
        }

        private DbContext Contexto { get; set; }

        //public virtual DbSet<PedidoAjuda> PedidoAjuda { get; set; }

        public void Add(PedidoAjuda pedidoAjudaParam)
        {
            try
            {
                Contexto.Set<PedidoAjuda>().Add(pedidoAjudaParam);
                var teste = pedidoAjudaParam;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public PedidoAjuda Get(PedidoAjuda pedidoAjudaParam)
        {
            try
            {
                if (pedidoAjudaParam != null)
                {
                    PedidoAjuda pedidoFiltro = new PedidoAjuda();

                    if (pedidoAjudaParam.IdPedidoAjuda > 0)
                    {
                        pedidoFiltro.IdPedidoAjuda = pedidoAjudaParam.IdPedidoAjuda;
                    }

                    return Contexto.Set<PedidoAjuda>().FirstOrDefault(m => m.IdPedidoAjuda == pedidoFiltro.IdPedidoAjuda);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Lista todos os registros de paginação
        /// </summary>
        /// <param name="pedidoAjudaParam"></param>
        /// <returns></returns>
        public List<PedidoAjuda> ListarGrid(GridParam paginacao)
        {
            try
            {


                return Contexto.Set<PedidoAjuda>().ToList();

            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
