using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using WebApplication.Constants;
using WebApplication.Models.Entity;
using WebApplication.Models.Out;

namespace WebApplication.Controllers
{
    public class UsuarioController : Controller
    {        
        public IActionResult Cadastrar()
        {
            ViewBag.Message = null;
            ViewBag.Sucesso = false;
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario)
        {            
            var usuarioOut = InserirUsuario(usuario);

            ViewBag.Message = usuarioOut.Sucesso ? null : usuarioOut.Mensagem;
            ViewBag.Sucesso = usuarioOut.Sucesso;
            return View();
        }

        private UsuarioOut InserirUsuario(Usuario usuario)
        {
            var usuarioOut = new UsuarioOut();
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Services.UrlBase);
                    var response = client.PostAsJsonAsync(Services.UrlAdicionarUsuario, usuario).Result;

                    usuarioOut.Sucesso = response.IsSuccessStatusCode;
                    usuarioOut.Mensagem = response.Content.ReadAsStringAsync().Result;
                }

                return usuarioOut;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
