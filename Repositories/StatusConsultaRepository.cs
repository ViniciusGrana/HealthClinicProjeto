using HealthClinic.Contexts;
using HealthClinic.Domains;
using HealthClinic.Intefaces;

namespace HealthClinic.Repositories
{
    public class StatusConsultaRepository : IStatusConsulta
    {
        private readonly HealthClinicContext _healthClinicContext;

        public StatusConsultaRepository()
        {
            _healthClinicContext = new HealthClinicContext();
        }
        public void Cadastrar(StatusConsulta statusConsulta)
        {
            try
            {
                _healthClinicContext.Add(statusConsulta);

                _healthClinicContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
