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
            throw new NotImplementedException();
        }

        public void Cadastrar(Paciente paciente)
        {
            _healthContext.Paciente.Add(paciente);
            _healthContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Paciente> Listar()
        {
            return _healthContext.Paciente.ToList();
        }
    }
}
