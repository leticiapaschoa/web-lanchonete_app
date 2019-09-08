using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Constants;
using WebApplication.Models.In;
using WebApplication.Models.To;

namespace WebApplication.Controllers
{
    public class CarrinhoController : Controller
    {
        public IActionResult CarrinhoCompras()
        {
            //var itens = BuscarItensCarrinho();           
            var itens = new List<ItemCompraIn>()
            {
                new ItemCompraIn
                {
                    Nome = "Hulk",
                    Preco = 26.00
                },
                new ItemCompraIn
                {
                    Nome = "Hulk",
                    Preco = 26.00
                },
                new ItemCompraIn
                {
                    Nome = "Homem de Ferro",
                    Preco = 47.00
                }
            };

            return View(AgruparItensCarrinho(itens));
        }

        public void Remover()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

                var response = httpClient.GetStringAsync(new Uri(Services.UrlRemoverItens)).Result;
            }
        }

        private List<ItensCompraTo> AgruparItensCarrinho(List<ItemCompraIn> itens)
        {
            return itens.GroupBy(x => x.Nome)
                        .Select(s => new ItensCompraTo { Item = s.Key, Quantidade = s.Count(), Valor = (s.Count() * s.FirstOrDefault().Preco) })
                        .ToList();
            
        }

        private List<ItemCompraIn> BuscarItensCarrinho()
        {
            var usuario = HttpContext.Session.GetString(Sessions.SessionUser);

            if (usuario is null)
            {
                throw new ArgumentNullException(nameof(usuario));
            }

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

                var response = httpClient.GetStringAsync(new Uri(Services.UrlBuscarItens)).Result;
            }

            return new List<ItemCompraIn>();
        }
    }
}