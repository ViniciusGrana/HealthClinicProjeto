using HealthClinic.Contexts;
using HealthClinic.Domains;
using HealthClinic.Intefaces;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace HealthClinic.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        private readonly HealthClinicContext _healthContext;
        public ConsultaRepository() 
        { 
            _healthContext = new HealthClinicContext();
        }

        public void Atualizar(Guid id, Consulta consulta)
        {
            Consulta consultaBuscada = _healthContext.Consulta.Find(id);
            if (consultaBuscada != null)
            {
                consultaBuscada.Prontuario = consulta.Prontuario;
                consultaBuscada.Descricao = consulta.Descricao;
            }
        }

        public void Cadastrar(Consulta consulta)
        {
            _healthContext.Consulta.Add(consulta);
            _healthContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Consulta consultaBuscada = _healthContext.Consulta.Find(id);
            _healthContext.Consulta.Remove(consultaBuscada);
            _healthContext.SaveChanges();
        }

        public List<Consulta> Listar()
        {
            return _healthContext.Consulta.ToList();
        }
    }
}
