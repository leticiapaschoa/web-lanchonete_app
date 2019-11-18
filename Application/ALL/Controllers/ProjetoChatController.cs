using System;
using System.Collections.Generic;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebApplication.Constants;
using WebApplication.Models.Entity;

namespace WebApplication.Controllers
{
    public class ProjetoChatController : Controller
    {
        public IActionResult Index()
        {
            var dados = ConsultarDadosProjeto1();
            
            return View(dados);
        }

        public List<Mensagem> ConsultarDadosProjeto1()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = client.GetAsync(Services.UrlProjetoChat).Result;
                    
                    if (response.IsSuccessStatusCode)
                    {
                        var mensagens = new List<Mensagem>();
                        var objJson = (JObject)JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);

                        objJson.Last.Remove();
                                                
                        foreach (var item in objJson)
                        {
                            var mensagem = new Mensagem
                            {
                                user = item.Value["user"].ToString(),
                                txt = item.Value["txt"].ToString()
                            };

                            mensagens.Add(mensagem);
                        }

                        return mensagens;
     
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}