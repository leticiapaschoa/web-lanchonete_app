﻿namespace WebApplication.Constants
{
    public static class Services
    {
        public const string UrlBase = "https://api-all2.azurewebsites.net";

        #region Login
        public const string UrlAutenticacao = "/api/Login";
        #endregion

        #region Cardapio
        public const string UrlCardapio = "/api/Lanche";
        public const string UrlCadastrarLanche = "/api/Lanche";
        public const string UrlDeletarLanche = "/api/Lanche/{0}";
        public const string UrlEditarLanche = "/api/Lanche/{0}";
        #endregion

        #region User
        public const string UrlAdicionarUsuario = "/api/User";
        #endregion

        #region ConsultarDadosProjetos
        public const string UrlProjetoChat = "https://api-chat-firebase.herokuapp.com/";
        #endregion
    }
}
