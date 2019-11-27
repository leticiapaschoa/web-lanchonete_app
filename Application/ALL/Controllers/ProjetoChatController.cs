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

        public IActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(Mensagem mensagem)
        {
            try
            {
                CadastrarMensagem(mensagem);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private void CadastrarMensagem(Mensagem mensagem)
        {
            using (var client = new HttpClient())
            {
                var response = client.PutAsJsonAsync(Services.UrlProjetoChat, mensagem).Result;
            }
        }

        private List<Mensagem> ConsultarDadosProjeto1()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = client.GetAsync(Services.UrlProjetoChat).Result;
                    
                    if (response.IsSuccessStatusCode)
                    {
                        var mensagens = new List<Mensagem>();
                        var objJson = (JObject)JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result.ToUpper());
                                                                        
                        foreach (var item in objJson)
                        {
                            var mensagem = new Mensagem
                            {
                                user = item.Value["USER"].ToString(),
                                txt = item.Value["TXT"].ToString()
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