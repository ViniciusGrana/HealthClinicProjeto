using HealthClinic.Domains;
using HealthClinic.Intefaces;
using HealthClinic.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicaController : ControllerBase
    {
        private IClinicaRepository _ClinicaRepository;

        public ClinicaController()
        {
            _ClinicaRepository = new ClinicaRepository();
        }

        [HttpGet]
        public IActionResult Get() 
        {
            try
            {
               return Ok(_ClinicaRepository.Listar());
                
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        
        }

        [HttpPut]
        public IActionResult Atualizar(Guid id, Clinica clinica) 
        {
            try
            {
                _ClinicaRepository.Atualizar(id, clinica);
                return Ok();
            }
            catch (Exception e )
            {

                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public IActionResult Deletar(Guid id)
        {
            try
            {
                _ClinicaRepository.Deletar(id);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Cadastrar(Clinica clinica)
        {
            try
            {
                _ClinicaRepository.Cadastrar(clinica);
                return Ok();
            }
            catch (Exception e)
            {

               return BadRequest($"{e.Message}");
            }
        }
    }
}
