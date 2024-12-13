using System.Collections.Generic;

namespace ProEventos.Domain
{
    public class Palestrante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public List<RedeSocial> RedeSocials { get; set; }

        public IEnumerable<PalestranteEvento> PalestrantesEventos { get; set; }
    }
}