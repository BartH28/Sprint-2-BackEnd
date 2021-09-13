using System;
using System.Collections.Generic;

#nullable disable

namespace Senai_inlock_api.Domains
{
    public partial class Jogo
    {
        public short IdJogo { get; set; }
        public string NomeJogo { get; set; }
        public string Descrição { get; set; }
        public DateTime? DataLançamento { get; set; }
        public decimal Valor { get; set; }
        public short? IdEstudio { get; set; }

        public virtual Estudio IdEstudioNavigation { get; set; }
    }
}
