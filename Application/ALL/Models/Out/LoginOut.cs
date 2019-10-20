using WebApplication.Models.Out;

namespace WebApplication.Models
{
    public class LoginOut : BaseOut
    {
        public LoginOut()
        {
            loginValido = false;
        }


        public string nomeUsuario { get; set; }
        public bool loginValido { get; set; }
    }
}
