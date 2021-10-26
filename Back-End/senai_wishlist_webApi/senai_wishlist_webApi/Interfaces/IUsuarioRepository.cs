using senai_wishlist_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_wishlist_webApi.Interfaces
{
    interface IUsuarioRepository
    {
        // Estrutura dos métodos
        // TipoRetorno NomeMetodo(TipoParametro NomeParametro);

        /// <summary>
        /// Lista todos os usuarios
        /// </summary>
        /// <returns>Retorna uma lista de usuarios</returns>
        List<Usuario> ListarTodos();

        /// <summary>
        /// Busca um usuario através do Id
        /// </summary>
        /// <param name="idUsuario">Id do usuario a ser buscado</param>
        /// <returns>Reporta um objeto do tipo Usuario</returns>
        Usuario BuscarPorId(int idUsuario);

        /// <summary>
        /// Cadastra um novo usuario
        /// </summary>
        /// <param name="novoUsuario">Objeto do tipo  a ser cadastrado</param>
        void Cadastrar(Usuario novoUsuario);
    }
}
