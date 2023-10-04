

using HealthClinic.Domains;
using HealthClinic.Intefaces;
using HealthClinic.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace webapi.event_.manha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TiposUsuarioController : ControllerBase
    {
        private ITipoUsuarioRepository _tiposUsuarioRepository;

        public TiposUsuarioController()
        {
            _tiposUsuarioRepository = new TipoUsuarioRepository();
        }
        /// <summary>
        /// Endpoint que aciona o metodo Cadastrar Tipousuarios
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(TiposUsuario tiposUsuario)
        {
            try
            {
                _tiposUsuarioRepository.Cadastrar(tiposUsuario);

                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Endpoint que aciona o metodo Deletar Tipousuarios
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Deletar(Guid id)
        {
            try
            {
                _tiposUsuarioRepository.Deletar(id);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Endpoint que aciona o metodo Listar Tipousuarios por id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(_tiposUsuarioRepository.BuscarPorID(id));

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Endpoint que aciona o metodo Listar Tipousuarios
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_tiposUsuarioRepository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Endpoint que aciona o metodo Atualizar Tipousuarios
        /// </summary>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, TiposUsuario tipoUsuario)
        {
            try
            {
                _tiposUsuarioRepository.Atualizar(id, tipoUsuario);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }


}