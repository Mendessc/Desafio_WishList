using System;
using System.Collections.Generic;

#nullable disable

namespace senai_wishlist_webApi.Domains
{
    public partial class Desejo
    {
        public short IdDesejo { get; set; }
        public string Descricao { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
