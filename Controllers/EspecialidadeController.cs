using HealthClinic.Domains;
using HealthClinic.Intefaces;
using HealthClinic.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspecialidadeController : ControllerBase
    {
        private IEspecialidadeRepository _EspecialidadeRepository;

        public EspecialidadeController()
        {
            _EspecialidadeRepository = new EspecialidadeRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_EspecialidadeRepository.Listar);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete(Guid id) 
        {
            try
            {
                _EspecialidadeRepository.Deletar(id);
            
               return Ok();
                     
            }
            catch (Exception e)
            {

                return BadRequest($"{e.Message}");  
            }
        }

        [HttpPut]
        public IActionResult Put(Guid id, Especialidade especialidade) 
        {
            try
            {
                _EspecialidadeRepository.Atualizar(id, especialidade);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Cadastrar(Especialidade especialidade)
        {
            try
            {
                _EspecialidadeRepository.Cadastrar(especialidade);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest($"{e.Message}");
            }
        }
    }
}
