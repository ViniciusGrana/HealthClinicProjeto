using HealthClinic.Domains;
using HealthClinic.Intefaces;
using HealthClinic.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProntuarioController : ControllerBase
    {
        private IProntuarioRepository _ProntuarioRepository;

        public ProntuarioController()
        {
            _ProntuarioRepository = new ProntuarioRepository();
        }

        /// <summary>
        /// Endpoint que aciona o metodo Listar Prontuario
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get() 
        {
            try
            {
                return Ok(_ProntuarioRepository.Listar());         
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }
        /// <summary>
        /// Endpoint que aciona o metodo Cadastrar Prontuario
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Cadastrar(Prontuario prontuario)
        {
            try
            {
                _ProntuarioRepository.Cadastrar(prontuario);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest($"Could not find {e.Message}");
            }
        }
        /// <summary>
        /// Endpoint que aciona o metodo Deletar Prontuario
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            try
            {
            _ProntuarioRepository.Deletar(id);
                return Ok();

            }
            catch (Exception e )
            {

                return BadRequest(e.Message); 
            }

        }
        /// <summary>
        /// Endpoint que aciona o metodo Atualizar Prontuario
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Atualizar(Guid id, Prontuario prontuario)
        {
            try
            {
                _ProntuarioRepository.Atualizar(id, prontuario);
                return Ok();
            }
            catch (Exception e)
            {

               return BadRequest($"{e.Message}");
            }
        }

    }
}
