﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using WebApplication.Constants;
using WebApplication.Models.Entity;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;

namespace WebApplication.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Menu()
        {
            var itensCardapio = ConsultarCardapio();

            return View(itensCardapio);
        }
       

        public IActionResult Adicionar()
        {
            return RedirectToAction("Menu", "Menu");
        }

        public CardapioOut ConsultarCardapio()
        {
            var cardapio = new CardapioOut();

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Services.UrlBase);
                    var response = client.GetAsync(Services.UrlCardapio).Result;

                    cardapio.Sucesso = response.IsSuccessStatusCode;

                    if (response.IsSuccessStatusCode)
                    {
                        cardapio.Lanches = JsonConvert.DeserializeObject<List<Lanche>>(response.Content.ReadAsStringAsync().Result);
                        
                        cardapio.Lanches
                            .Where(lanche => string.IsNullOrEmpty(lanche.ImagemUrl) || lanche.ImagemUrl.Equals("string")).ToList()
                            .ForEach(l => l.ImagemUrl = ConstsBase.ImgDefault);
                    }
                }

                return cardapio;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}