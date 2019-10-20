using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication.Constants;
using WebApplication.Models;
using System.Net.Http;

namespace WebApplication.Controllers
{
    public class LoginController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        public IActionResult Login()
        {
            ViewBag.UsuarioInvalido = false;
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginIn loginIn)
        {
            ViewBag.UsuarioInvalido = true;

            if (loginIn is null)
            {
                throw new ArgumentNullException(nameof(loginIn));
            }

            var loginOut = RealizarLoginAsync(loginIn);

            if (loginOut.loginValido)
            {
                HttpContext.Session.SetString(Sessions.SessionUser, loginIn.Login);
                ViewBag.Usuario = HttpContext.Session.GetString(Sessions.SessionUser);
                ViewBag.UsuarioInvalido = false;
                return RedirectToAction("Index", "Home");
            }
            
            return View();
        }
                
        public IActionResult Logout(LoginIn loginIn)
        {
            HttpContext.Session.Remove(Sessions.SessionUser);

            return RedirectToAction("Index", "Home");
        }       

        private LoginOut RealizarLoginAsync(LoginIn loginIn)
        {
            var loginOut = new LoginOut();

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Services.UrlBase);
                    var response = client.PostAsJsonAsync(Services.UrlAutenticacao, loginIn).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        loginOut.loginValido = response.Content.ReadAsStringAsync().Result.Contains("token");
                    }
                    else
                    {
                        loginOut.Mensagem = "Usuário e/ou senha inválidos";
                    }
                }

                return loginOut;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}