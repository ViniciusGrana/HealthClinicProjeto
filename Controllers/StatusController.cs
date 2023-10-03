using HealthClinic.Domains;
using HealthClinic.Intefaces;
using HealthClinic.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private IStatusConsulta _statusConsultaRepository;

        public StatusController()
        {
            _statusConsultaRepository = new StatusConsultaRepository();
        }

        /// <summary>
        /// Endpoint que aciona o método de cadastrar um status de consulta
        /// </summary>
        /// <param name="statusConsulta">Status de consulta a ser cadastrado</param>
        /// <returns>StatusCode(201) sucess</returns>
        [HttpPost]
        public IActionResult Cadastrar(StatusConsulta statusConsulta)
        {
            try
            {
                _statusConsultaRepository.Cadastrar(statusConsulta);

                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
