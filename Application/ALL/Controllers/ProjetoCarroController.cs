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
            BuscarUsuarios();
            return View();
        }

        public List<CarroUsuario> BuscarUsuarios()
        {

            string _connection = "server=thanos-web.database.windows.net;user id=andrelivee;password=andrelivee;Trusted_Connection=true;Database=Carros;Connection timeout=6000";
            
                using (SqlConnection sqlcon = new SqlConnection(_connection))
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Nome, Email FROM Cliente", sqlcon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    //teste.DataSource = dtbl;
                    //teste.DataBind();
                }
            



            string connectionString = "Server=thanos-web.database.windows.net; User Id=andrelivee; Password=@andre123;Trusted_Connection=false;Encrypt=false;TrustServerCertificate=True;Database=Carros;Connection timeout=6000";

            var connection = new SqlConnection(connectionString);
            connection.Open();
            var command = new SqlCommand("SELECT nome, email FROM dbo.cliente", connection);
            
            string result = (string)command.ExecuteScalar();

            connection.Close();


            return new List<CarroUsuario>();
        }
    }
}