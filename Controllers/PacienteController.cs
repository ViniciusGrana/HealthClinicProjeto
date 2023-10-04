using HealthClinic.Domains;
using HealthClinic.Intefaces;
using HealthClinic.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace HealthClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class PacienteController : Controller
    {
        private IPacienteRepository _PacienteRepository;

        public PacienteController()
        {
            _PacienteRepository = new PacienteRepository();
        }

        /// <summary>
        /// Endpoint que aciona o metodo Listar Paciente
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
              return Ok(_PacienteRepository.Listar());
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Endpoint que aciona o metodo Cadastrar Paciente
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Cadastrar(Paciente paciente)
        {
            try
            {
                _PacienteRepository.Cadastrar(paciente);
                    return Ok();
            }
            catch (Exception e)
            {
                return BadRequest($"{e.Message}");
            }
        }
        /// <summary>
        /// Endpoint que aciona o metodo Deletar Paciente
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public IActionResult Deletar(Guid id) 
        {
            try
            {
                _PacienteRepository.Deletar(id);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Endpoint que aciona o metodo Buscar Paciente por id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(Guid id) 
        {
            try
            {
                return Ok(_PacienteRepository.BuscarPorID(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
