using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Constants;
using WebApplication.Models.In;

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
                    Preco = 26
                },
                new ItemCompraIn
                {
                    Nome = "Homem de Ferro",
                    Preco = 47
                }
            };
            return View(itens);
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
            throw new NotImplementedException();
        }
    }
}