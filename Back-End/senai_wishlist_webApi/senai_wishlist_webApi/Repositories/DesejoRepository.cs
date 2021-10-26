using senai_wishlist_webApi.Contexts;
using senai_wishlist_webApi.Domains;
using senai_wishlist_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_wishlist_webApi.Repositories
{
    public class DesejoRepository : IDesejoRepository
    {
        WishListContext ctx = new WishListContext();
        public Desejo BuscarPorId(int idDesejo)
        {
            return ctx.Desejos.FirstOrDefault(e => e.IdDesejo == idDesejo);
        }

        public void Cadastrar(Desejo novoDesejo)
        {
            ctx.Desejos.Add(novoDesejo);
            ctx.SaveChanges();

        }

        public List<Desejo> ListarTodos()
        {
            return ctx.Desejos.ToList();
        }
    }
}
