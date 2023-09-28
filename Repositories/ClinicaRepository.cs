using HealthClinic.Contexts;
using HealthClinic.Domains;
using HealthClinic.Intefaces;

namespace HealthClinic.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
    private readonly HealthClinicContext _healthContext;
    public ClinicaRepository()
    {
        _healthContext = new HealthClinicContext();
    }
        public void Atualizar(Guid id, Clinica clinica)
        {
            Clinica clinicaBuscada = _healthContext.Clinica.Find(id);

            if (clinicaBuscada != null)
            {
                clinicaBuscada.CNPJ  = clinica.CNPJ;
                clinicaBuscada.Abertura = clinica.Abertura;
                clinicaBuscada.RazaoSocial = clinica.RazaoSocial;
            }

            _healthContext.Clinica.Update(clinicaBuscada!);

            _healthContext.SaveChanges();
        }

        public void Cadastrar(Clinica clinica)
        {
            _healthContext.Clinica.Add(clinica);
            _healthContext.SaveChanges();

        }

        public void Deletar(Guid id)
        {
            Clinica clinicaBuscada = _healthContext.Clinica.Find(id);
            _healthContext.Clinica.Remove(clinicaBuscada);
            _healthContext.SaveChanges();
                }

        public List<Clinica> Listar()
        {
            return _healthContext.Clinica.ToList();
        }
    }
}
