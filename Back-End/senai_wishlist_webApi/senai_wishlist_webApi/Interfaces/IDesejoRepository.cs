using senai_wishlist_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_wishlist_webApi.Interfaces
{
    interface IDesejoRepository
    {
        // Estrutura dos métodos
        // TipoRetorno NomeMetodo(TipoParametro NomeParametro);

        /// <summary>
        /// Lista todos os desejos
        /// </summary>
        /// <returns>Retorna uma lista de desejos</returns>
        List<Desejo> ListarTodos();

        /// <summary>
        /// Busca um desejo através do Id
        /// </summary>
        /// <param name="idDesejo">Id do desejo a ser buscado</param>
        /// <returns>Reporta um objeto do tipo DesejoDomain</returns>
        Desejo BuscarPorId(int idDesejo);

        /// <summary>
        /// Cadastra um novo desejo
        /// </summary>
        /// <param name="novoDesejo">Objeto do tipo Desejo a ser cadastrado</param>
        void Cadastrar(Desejo novoDesejo);
    }
}
