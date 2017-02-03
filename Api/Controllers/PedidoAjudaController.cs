using Entidade;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class PedidoAjudaController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Add(PedidoAjuda pedidoAjudaParam)
        {
            try
            {
                using (var pedidoAjudaNeg = new PedidoAjudaNeg())
                {
                    pedidoAjudaNeg.Add(pedidoAjudaParam);
                }

                return Request.CreateResponse(HttpStatusCode.OK, true);
            }
            catch (Exception exc)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, exc.Message);
            }
        }
        public HttpResponseMessage Get()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, true);
            }
            catch (Exception exc)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, exc.Message);
            }
        }

        /// <summary>
        /// Método responsável por listar os dados para grid
        /// </summary>
        /// <param name="paginacao"></param>
        /// <param name="parametros"></param>
        /// <returns></returns>
        public HttpResponseMessage ListarGrid(GridParam paginacao)
        {
            try
            {
                //TODO: alterar filtro para forma genérica
                //e retorno genérico
                List<PedidoAjuda> listaRetornoAux = null;

                if(paginacao.Filtros != null)
                {
                    paginacao.Filtros = null;
                }

                using (PedidoAjudaNeg pedidoAjudaNeg = new PedidoAjudaNeg())
                {
                    listaRetornoAux = pedidoAjudaNeg.Listar(paginacao);

                    var listaRetorno = from item in listaRetornoAux
                                       select new
                                       {
                                           UrlImagem = item.AnexoPedidoAjuda.FirstOrDefault(),
                                           NomeImagem = item.AnexoPedidoAjuda,
                                           TituloEvento = "",
                                           DescricaoEvento = item.Descricao,
                                           DataCadastro = item.DtCadastro,
                                           RegiaoDistancia = item.PedidoAjudaLocalEntrega.FirstOrDefault().LocalEntrega.Nome + " 25KM" //TODO: CORRIGIR
                                       };

                }


                return Request.CreateResponse(HttpStatusCode.OK, new List<PedidoAjuda>());
            }
            catch (Exception exc)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, exc.Message);
            }
        }

        public HttpResponseMessage Update()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, true);
            }
            catch (Exception exc)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, exc.Message);
            }
        }

        #region MOCK DE TESTE

        [HttpPost]
        public HttpResponseMessage ListarTeste(GridParam GridParametros)
        {
            try
            {
                var lst = new List<object>();

                lst.Add(new
                {
                    UrlImagem = "/img/1.jpg",
                    NomeImagem = "imagem teste 1",
                    TituloEvento = "preciso da sua ajuda",
                    DescricaoEvento = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",
                    DataCadastro = "21/09/2016",
                    RegiaoDistancia = "Viamão RS - 25KM"
                });
                lst.Add(new
                {
                    UrlImagem = "/img/2.jpg",
                    NomeImagem = "imagem teste 2",
                    TituloEvento = "estou necessido",
                    DescricaoEvento = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",
                    DataCadastro = "23/09/2016",
                    RegiaoDistancia = "Porto Alegre RS - 25KM"
                });
                lst.Add(new
                {
                    UrlImagem = "/img/3.jpg",
                    NomeImagem = "imagem teste 3",
                    TituloEvento = "e agora quem poderá",
                    DescricaoEvento = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",
                    DataCadastro = "21/04/2016",
                    RegiaoDistancia = "Águas Claras RS - 25KM"
                });
                lst.Add(new
                {
                    UrlImagem = "/img/4.jpg",
                    NomeImagem = "imagem teste 4",
                    TituloEvento = "poderá me ajudar",
                    DescricaoEvento = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",
                    DataCadastro = "17/03/2016",
                    RegiaoDistancia = "Alvorada RS - 35KM"
                }); lst.Add(new
                {
                    UrlImagem = "/img/5.jpg",
                    NomeImagem = "imagem teste 5",
                    TituloEvento = "ajuda ajuda ajuda",
                    DescricaoEvento = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",
                    DataCadastro = "11/03/2016",
                    RegiaoDistancia = "Charqueadas RS - 23KM"
                });
                lst.Add(new
                {
                    UrlImagem = "/img/6.jpg",
                    NomeImagem = "imagem teste 6",
                    TituloEvento = "ajuda ajuda wqajuda",
                    DescricaoEvento = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",
                    DataCadastro = "11/04/2016",
                    RegiaoDistancia = "Cachoeirinha RS - 23KM"
                });
                lst.Add(new
                {
                    UrlImagem = "/img/6.jpg",
                    NomeImagem = "imagem teste 7",
                    TituloEvento = "ajuda ajuda wqajuda",
                    DescricaoEvento = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",
                    DataCadastro = "11/04/2016",
                    RegiaoDistancia = "Cachoeirinha RS - 23KM"
                }); lst.Add(new
                {
                    UrlImagem = "/img/5.jpg",
                    NomeImagem = "imagem teste 8",
                    TituloEvento = "ajuda ajuda wqajuda",
                    DescricaoEvento = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",
                    DataCadastro = "11/04/2016",
                    RegiaoDistancia = "Cachoeirinha RS - 23KM"
                }); lst.Add(new
                {
                    UrlImagem = "/img/4.jpg",
                    NomeImagem = "imagem teste 9",
                    TituloEvento = "ajuda ajuda wqajuda",
                    DescricaoEvento = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",
                    DataCadastro = "11/04/2016",
                    RegiaoDistancia = "Cachoeirinha RS - 23KM"
                }); lst.Add(new
                {
                    UrlImagem = "/img/3.jpg",
                    NomeImagem = "imagem teste 10",
                    TituloEvento = "ajuda ajuda wqajuda",
                    DescricaoEvento = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",
                    DataCadastro = "11/04/2016",
                    RegiaoDistancia = "Cachoeirinha RS - 23KM"
                }); lst.Add(new
                {
                    UrlImagem = "/img/2.jpg",
                    NomeImagem = "imagem teste 11",
                    TituloEvento = "ajuda ajuda wqajuda",
                    DescricaoEvento = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",
                    DataCadastro = "11/04/2016",
                    RegiaoDistancia = "Cachoeirinha RS - 23KM"
                });
                lst.Add(new
                {
                    UrlImagem = "/img/3.jpg",
                    NomeImagem = "imagem teste 12",
                    TituloEvento = "ajuda ajuda wqajuda",
                    DescricaoEvento = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",
                    DataCadastro = "11/04/2016",
                    RegiaoDistancia = "Cachoeirinha RS - 23KM"
                }); lst.Add(new
                {
                    UrlImagem = "/img/2.jpg",
                    NomeImagem = "imagem teste 13",
                    TituloEvento = "ajuda ajuda wqajuda",
                    DescricaoEvento = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",
                    DataCadastro = "11/04/2016",
                    RegiaoDistancia = "Cachoeirinha RS - 23KM"
                }); lst.Add(new
                {
                    UrlImagem = "/img/1.jpg",
                    NomeImagem = "imagem teste 14",
                    TituloEvento = "ajuda ajuda wqajuda",
                    DescricaoEvento = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",
                    DataCadastro = "11/04/2016",
                    RegiaoDistancia = "Cachoeirinha RS - 23KM"
                }); lst.Add(new
                {
                    UrlImagem = "/img/1.jpg",
                    NomeImagem = "imagem teste 15",
                    TituloEvento = "ajuda ajuda wqajuda",
                    DescricaoEvento = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",
                    DataCadastro = "11/04/2016",
                    RegiaoDistancia = "Cachoeirinha RS - 23KM"
                }); lst.Add(new
                {
                    UrlImagem = "/img/3.jpg",
                    NomeImagem = "imagem teste 16",
                    TituloEvento = "ajuda ajuda wqajuda",
                    DescricaoEvento = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",
                    DataCadastro = "11/04/2016",
                    RegiaoDistancia = "Cachoeirinha RS - 23KM"
                }); lst.Add(new
                {
                    UrlImagem = "/img/2.jpg",
                    NomeImagem = "imagem teste 17",
                    TituloEvento = "ajuda ajuda wqajuda",
                    DescricaoEvento = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",
                    DataCadastro = "11/04/2016",
                    RegiaoDistancia = "Cachoeirinha RS - 23KM"
                });

                var objRetorno = new { Total = lst.Count, ListaPedidosAjuda = lst };

                return Request.CreateResponse(HttpStatusCode.OK, objRetorno);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
