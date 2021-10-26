using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_wishlist_webApi.Domains;
using senai_wishlist_webApi.Interfaces;
using senai_wishlist_webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_wishlist_webApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }
        public UsuariosController()
        {
            _usuarioRepository = new UsuarioRepository();
        }
        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(_usuarioRepository.ListarTodos());
        }

        /// <summary>
        /// Busca um usuario através do seu id
        /// </summary>
        /// <param name="idUsuario">ID do usuario que será buscado</param>
        /// <returns>Um desejo e um status code 200 - Ok</returns>
        [HttpGet("{idUsuario}")]
        public IActionResult BuscarPorId(int idUsuario)
        {
            return Ok(_usuarioRepository.BuscarPorId(idUsuario));
        }
        [HttpPost]
        public IActionResult Cadastrar(Usuario novoUsuario)
        {
            _usuarioRepository.Cadastrar(novoUsuario);

            return StatusCode(201);
        }
    }
}
