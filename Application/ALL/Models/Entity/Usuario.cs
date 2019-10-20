using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models.Entity
{
    public class Usuario
    {
        [Required][StringLength(14, MinimumLength = 11)]
        public string Cpf { get; set; }
        [Required][StringLength(50, MinimumLength = 2)]
        public string Nome { get; set; }
        [Required][EmailAddress][StringLength(50, MinimumLength = 2)]
        public string Email { get; set; }
        [Required][Phone]
        public string Telefone { get; set; }
        [Required][StringLength(50, MinimumLength = 2)]
        public string Login { get; set; }
        [Required][StringLength(8, MinimumLength = 0)]
        public string Senha { get; set; }
        [Required][StringLength(10, MinimumLength = 0)]
        public string Cep { get; set; }
        [StringLength(100, MinimumLength = 0)]
        public string Cidade { get; set; }
        [StringLength(100, MinimumLength = 0)]
        public string Bairro { get; set; }
        [StringLength(100, MinimumLength = 0)]
        public string Rua { get; set; }
        public int Numero { get; set; }
    }
}
