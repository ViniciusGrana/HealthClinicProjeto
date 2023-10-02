using HealthClinic.Contexts;
using HealthClinic.Domains;
using HealthClinic.Intefaces;

namespace HealthClinic.Repositories
{
    public class ProntuarioRepository : IProntuarioRepository
    {
        private readonly HealthClinicContext _healthContext;
        public ProntuarioRepository()
        {
            _healthContext = new HealthClinicContext();
        }

        public void Atualizar(Guid id, Prontuario prontuario)
        {
            Prontuario prontoBuscado = _healthContext.Prontuario.Find(id);
            if (prontoBuscado != null)
            {
                prontoBuscado.Descricao = prontuario.Descricao;
            }
            _healthContext.Prontuario.Update(prontoBuscado!);
            _healthContext.SaveChanges();

        }

        public void Cadastrar(Prontuario prontuario)
        {
            _healthContext.Prontuario.Add(prontuario);
            _healthContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Prontuario prontuarioBuscado = _healthContext.Prontuario.Find(id);
            _healthContext.Prontuario.Remove(prontuarioBuscado);
            _healthContext.SaveChanges();
        }

        public List<Prontuario> Listar()
        {
            return _healthContext.Prontuario.ToList();
        }
    }
}
