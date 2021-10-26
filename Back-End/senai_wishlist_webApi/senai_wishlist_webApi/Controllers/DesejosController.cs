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
    public class DesejosController : ControllerBase
    {
        private IDesejoRepository _desejoRepository { get; set; }

        public DesejosController()
        {
            _desejoRepository = new DesejoRepository();
        }
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_desejoRepository.ListarTodos());
        }

        /// <summary>
        /// Busca um desejo através do seu id
        /// </summary>
        /// <param name="idDesejo">ID do desejo que será buscado</param>
        /// <returns>Um desejo e um status code 200 - Ok</returns>
        [HttpGet("{idDesejo}")]
        public IActionResult BuscarPorId(int idDesejo)
        {
            return Ok(_desejoRepository.BuscarPorId(idDesejo));
        }
        [HttpPost]
        public IActionResult Cadastrar(Desejo novoDesejo)
        {
            _desejoRepository.Cadastrar(novoDesejo);

            return StatusCode(201);
        }
    }

}
