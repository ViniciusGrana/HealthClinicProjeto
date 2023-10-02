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
