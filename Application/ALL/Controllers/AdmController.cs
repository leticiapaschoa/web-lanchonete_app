using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication.Constants;
using WebApplication.Models.Entity;
using WebApplication.Models.In;
using WebApplication.Models.Out;

namespace WebApplication.Controllers
{
    public class AdmController : Controller
    {
        public ActionResult Index()
        {
            var consultaOut = new MenuController().ConsultarCardapio();

            return View(consultaOut.Lanches);
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Lanche lanche)
        {
            try
            {
                var cadastrarOut = CadastrarLanche(lanche);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Editar(string id)
        {
            var lanche = new MenuController().ConsultarCardapio()
                                        .Lanches
                                        .FirstOrDefault(l => l.Id.Equals(id));

            return View(lanche);
        }

        [HttpPost]
        public ActionResult Editar(string id, Lanche lanche)
        {
            try
            {
                var admOut = EditarLanche(id, lanche);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Deletar(string id)
        {
            try
            {
                DeletarLanche(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private AdmOut CadastrarLanche(Lanche lanche)
        {
            var admInserirOut = new AdmOut();
            try
            {
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<Lanche, AdmLancheIn>();
                });

                IMapper iMapper = config.CreateMapper();

                var admLancheIn = iMapper.Map<Lanche, AdmLancheIn>(lanche);

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Services.UrlBase);
                    var response = client.PostAsJsonAsync(Services.UrlCadastrarLanche, admLancheIn).Result;

                    admInserirOut.Sucesso = response.IsSuccessStatusCode;
                    admInserirOut.Mensagem = response.Content.ReadAsStringAsync().Result;
                }

                return admInserirOut;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private AdmOut EditarLanche(string id, Lanche lanche)
        {
            var admInserirOut = new AdmOut();
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Services.UrlBase);
                    var response = client.PutAsJsonAsync(string.Format(Services.UrlEditarLanche, id), lanche).Result;

                    admInserirOut.Sucesso = response.IsSuccessStatusCode;
                    admInserirOut.Mensagem = response.Content.ReadAsStringAsync().Result;
                }

                return admInserirOut;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void DeletarLanche(string id)
        {          
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Services.UrlBase);
                    var response = client.GetAsync(string.Format(Services.UrlDeletarLanche, id)).Result;
                    
                }               
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}