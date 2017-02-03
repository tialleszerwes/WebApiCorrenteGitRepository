using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class GridParam
    {
        public int Total { get; set; }
        public int NumPagina { get; set; }
        public int RegistrosPorPagina { get; set; }
        /// <summary>
        /// Na controller deve fazer um cast para objeto de seu filtro
        /// </summary>
        public object Filtros { get; set; }
        public List<object> ListaRetorno { get; set; }
        /// <summary>
        /// Passar a ordem dos parâmetros dividido por ';'
        /// </summary>
        public string Ordenacao { get; set; }
    }
}
