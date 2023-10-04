using HealthClinic.Domains;
using HealthClinic.Intefaces;
using HealthClinic.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }
        /// <summary>
        /// Endpoint que aciona o metodo Cadastrar Usuario
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            try
            {
                _usuarioRepository.Cadastrar(usuario);

                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Endpoint que aciona o metodo Buscar Usuarios por id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]

        public IActionResult BuscarPorId(Guid id)
        {
            try
            {
                return Ok(_usuarioRepository.BuscarPorId(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Endpoint que aciona o metodo Buscar Usuario por email e senha
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult BuscarPorEmailESenha(string email, string senha)
        {
            try
            {
                return Ok(_usuarioRepository.BuscarPorEmailESenha(email, senha));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}




