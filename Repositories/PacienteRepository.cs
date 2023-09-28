using HealthClinic.Contexts;
using HealthClinic.Domains;
using HealthClinic.Intefaces;

namespace HealthClinic.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly HealthClinicContext _healthContext;

        public PacienteRepository()
        {
            _healthContext = new HealthClinicContext();
        }
        public Paciente BuscarPorID(Guid id)
        {
            return _healthContext.Paciente.FirstOrDefault(e => e.IdPaciente == id)!;
        }

        public void Cadastrar(Paciente paciente)
        {
            _healthContext.Paciente.Add(paciente);
            _healthContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Paciente pacienteBuscado = _healthContext.Paciente.Find(id);
            _healthContext.Paciente.Remove(pacienteBuscado);
            _healthContext.SaveChanges();
        }

        public List<Paciente> Listar()
        {
            return _healthContext.Paciente.ToList();
        }
    }
}
