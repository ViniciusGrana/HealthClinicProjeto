using HealthClinic.Contexts;
using HealthClinic.Intefaces;
using webapihealthclinic.Domains;

namespace HealthClinic.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly HealthClinicContext _healthClinic;
        public MedicoRepository() 
        {
          _healthClinic= new HealthClinicContext();
        }
        public Medico BuscarPorID(Guid id)
        {
          return  _healthClinic.Medico.FirstOrDefault(e => e.IdMedico == id);
        }

        public void Cadastrar(Medico medico)
        {
            _healthClinic.Medico.Add(medico);
            _healthClinic.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Medico medicoDespedido = _healthClinic.Medico.Find(id);
            _healthClinic.Medico.Remove(medicoDespedido);
            _healthClinic.SaveChanges();    

        }

        public List<Medico> Listar()
        {
            return _healthClinic.Medico.ToList();
        }
    }
}
