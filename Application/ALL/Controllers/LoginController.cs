using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using WebApplication.Constants;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            ViewBag.UsuarioInvalido = false;
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginIn loginBE)
        {
            ViewBag.UsuarioInvalido = true;

            try
            {
                //var login = RealizarLogin(loginBE);
                var login = new LoginOut
                {
                    nomeUsuario = "Leticia",
                    loginValido = true
                };

                if(login.loginValido)
                {
                    HttpContext.Session.SetString(Sessions.SessionUser, login?.nomeUsuario);
                    ViewBag.Usuario = HttpContext.Session.GetString(Sessions.SessionUser);
                    ViewBag.UsuarioInvalido = false;
                    return RedirectToAction("Index", "Home", HttpContext.Session);
                }  
            }
            catch (Exception ex)
            {
                ViewData["Message"] = $"Ocorreu um erro ao realizar o login. Por favor tente novamente. [{ex.Message}]";
            }

            return View();
        }

        private LoginOut RealizarLogin(LoginIn loginIn)
        {
            if (loginIn is null)
            {
                throw new ArgumentNullException(nameof(loginIn));
            }

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                
                var response = httpClient.GetStringAsync(new Uri(Services.UrlAutenticacao)).Result;

                return new LoginOut { nomeUsuario = response };
            }
        }
    }
}