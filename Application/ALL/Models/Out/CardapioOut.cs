using System.Collections.Generic;
using WebApplication.Models.Out;

namespace WebApplication.Models.Entity
{
    public class CardapioOut : BaseOut

    {
        public CardapioOut()
        {
            Lanches = new List<Lanche>();
        }

        public List<Lanche> Lanches { get; set; }
    }
}
