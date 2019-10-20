namespace WebApplication.Constants
{
    public static class Services
    {
        public const string UrlBase = "https://api-all.azurewebsites.net";
        public const string UrlCardapio = "/api/Lanche";
        public const string UrlAutenticacao = "/api/Login";        
        public const string UrlAdicionarItemCarrinho = "/api/CarrinhoCompra";
        public const string UrlBuscarItens = "https://localhost:44368/api/values";
        public const string UrlRemoverItens = "https://localhost:44368/api/values";

        #region User
        public const string UrlAdicionarUsuario = "/api/User";
        #endregion
    }
}
