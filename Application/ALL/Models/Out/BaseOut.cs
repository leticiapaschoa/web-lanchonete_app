namespace WebApplication.Models.Out
{
    public class BaseOut
    {
        public BaseOut()
        {
            Sucesso = false;
        }

        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
    }
}
