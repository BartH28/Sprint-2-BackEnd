using System;
using System.Collections.Generic;

#nullable disable

namespace Senai_inlock_api.Domains
{
    public partial class Usuario
    {
        public short IdUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public short? IdTipoUsuario { get; set; }

        public virtual TipoDeUsuario IdTipoUsuarioNavigation { get; set; }
    }
}
