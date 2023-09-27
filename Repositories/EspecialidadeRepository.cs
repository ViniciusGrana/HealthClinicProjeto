using HealthClinic.Contexts;
using HealthClinic.Domains;
using HealthClinic.Intefaces;

namespace HealthClinic.Repositories
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {

        private readonly HealthClinicContext _healthContext;
        public EspecialidadeRepository() 
        {
            _healthContext = new HealthClinicContext();
        }

        public void Atualizar(Guid id, Especialidade especialidade)
        {
            Especialidade especialidadeBuscada = _healthContext.Especialidade.Find(id);
            if (especialidadeBuscada != null)
            {
                especialidadeBuscada.TituloEspecialidade = especialidade.TituloEspecialidade;
                 
            }
           _healthContext.Especialidade.Update(especialidadeBuscada);
            _healthContext.SaveChanges();
        }

        public void Cadastrar(Especialidade especialidade)
        {
            _healthContext.Especialidade.Add(especialidade);
            _healthContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Especialidade especialidadeBuscada = _healthContext.Especialidade.Find(id)!;
            _healthContext.Especialidade.Remove(especialidadeBuscada);
            _healthContext.SaveChanges();

        }

        public List<Especialidade> Listar()
        {
           return _healthContext.Especialidade.ToList();
        }
    }
}
