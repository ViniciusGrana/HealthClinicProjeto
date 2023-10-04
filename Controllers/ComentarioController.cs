using HealthClinic.Domains;
using HealthClinic.Intefaces;
using HealthClinic.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComentarioController : ControllerBase
    {
        private IComentarioRepository _comentarioRepository;

        public ComentarioController()
        {
            _comentarioRepository = new ComentarioRepository();
        }

        /// <summary>
        /// Endpoint que aciona o metodo Cadastrar Comentario
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Cadastrar(Comentario comentario)
        {
            try
            {
                _comentarioRepository.Cadastrar(comentario);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Endpoint que aciona o metodo Listar Comentario
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Listar() 
        {
            try
            {
                return Ok(_comentarioRepository.Listar());
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint que aciona o metodo Deletar Comentario
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public IActionResult Delete(Guid id) 
        {
            try
            {
                _comentarioRepository.Deletar(id);
                return Ok();
            }
            catch (Exception e)
            {

               return BadRequest(
                   e.Message);
            }
        }
    }
}
