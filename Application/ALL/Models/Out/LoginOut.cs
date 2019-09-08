using WebApplication.Models.Out;

namespace WebApplication.Models
{
    public class LoginOut : BaseOut
    {
        public string nomeUsuario { get; set; }
        public bool loginValido { get; set; }
    }
}
