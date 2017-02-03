using Entidade;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocio
{
    public class PedidoAjudaNeg : Negocio
    {
        public List<PedidoAjuda> Listar(GridParam paginacao)
        {
            try
            {
                PedidoAjudaRep repositorioPA = new PedidoAjudaRep();

                return repositorioPA.ListarGrid(paginacao);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Add(PedidoAjuda pedidoAjudaParam)
        {
            try
            {
                PedidoAjudaRep repositorioPA = new PedidoAjudaRep();

                repositorioPA.Add(pedidoAjudaParam);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}