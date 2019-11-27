using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models.Entity;

namespace WebApplication.Controllers
{
    public class ProjetoCarroController : Controller
    {
        public IActionResult Index()
        {
            var cliente = BuscarUsuarios();
            return View(cliente);
        }

        public IActionResult Inserir()
        {   
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(CarroUsuario usuario)
        {
            try
            {
                CadastrarUsuario(usuario);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private void CadastrarUsuario(CarroUsuario usuario)
        {
            var Conexao = new SqlConnection
            {
                ConnectionString = "Server=thanos-web.database.windows.net;user id=andrelivee;pwd=@andre123;Database=Carros"
            };

            Conexao.Open();

            using (SqlCommand command = Conexao.CreateCommand())
            {
                command.CommandText = "INSERT INTO cliente (nome, email) VALUES(@param1,@param2)";

                command.Parameters.AddWithValue("@param1", usuario.nome);
                command.Parameters.AddWithValue("@param2", usuario.email);

                command.ExecuteNonQuery();
            }

            Conexao.Close();

        }

        private List<String[]> BuscarUsuarios()
        {
            var Conexao = new SqlConnection
            {
                ConnectionString = "Server=thanos-web.database.windows.net;user id=andrelivee;pwd=@andre123;Database=Carros"
            };
            
            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "SELECT nome, email FROM cliente";

            SqlDataReader Leitor = Comando.ExecuteReader();

            List<String[]> clientes = new List<String[]>();
            while (Leitor.Read())
            {
                String[] cliente = new String[1000];
                cliente[0] = Leitor["nome"].ToString();
                cliente[1] = Leitor["email"].ToString();
                

                clientes.Add(cliente);
            }

            Conexao.Close();

            return clientes;
        }
    }
}