using System;
using System.Collections.Generic;

#nullable disable

namespace Senai_inlock_api.Domains
{
    public partial class Estudio
    {
        public Estudio()
        {
            Jogos = new HashSet<Jogo>();
        }

        public short IdEstudio { get; set; }
        public string NomeEstudio { get; set; }

        public virtual ICollection<Jogo> Jogos { get; set; }
    }
}
