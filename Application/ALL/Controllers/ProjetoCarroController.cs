using System;
using System.Collections.Generic;
using System.Data;
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

        public List<String[]> BuscarUsuarios()
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = "server=thanos-web.database.windows.net;user id=andrelivee;password=andrelivee;Trusted_Connection=true;Database=Carros;Connection timeout=6000";

            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "SELECT * FROM cliente";

            SqlDataReader Leitor = Comando.ExecuteReader();

            List<String[]> clientes = new List<String[]>();
            while (Leitor.Read())
            {
                String[] cliente = new String[6];
                cliente[0] = Leitor["nome"].ToString();
                cliente[1] = Leitor["email"].ToString();
                

                clientes.Add(cliente);
            }

            Conexao.Close();

            return clientes;




            //string connString = "server=thanos-web.database.windows.net;user id=andrelivee;password=andrelivee;Trusted_Connection=true;Database=Carros;Connection timeout=6000";


            //var connection = new SqlConnection(connString);
            //connection.Open();
            //var command = new SqlCommand("SELECT nome, email FROM dbo.cliente", connection);

            //connection.Close();

            //return command.ExecuteReader().Read();


        }
    }
}