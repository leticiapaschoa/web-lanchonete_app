using Microsoft.AspNetCore.Mvc;
using WebApplication.Models.In;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using WebApplication.Constants;
using Microsoft.AspNetCore.Http;

namespace WebApplication.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Adicionar(ItemCompraIn item)
        {
            if (item is null)            
                throw new ArgumentNullException(nameof(item));
            
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

                var response = httpClient.GetStringAsync(new Uri(Services.UrlAdicionarItem)).Result;                
            }

            return RedirectToAction("Menu", "Menu");
        }
    }
}