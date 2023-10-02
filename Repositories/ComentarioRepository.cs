using HealthClinic.Contexts;
using HealthClinic.Domains;
using HealthClinic.Intefaces;

namespace HealthClinic.Repositories
{
    public class ComentarioRepository : IComentarioRepository
    {
        private readonly HealthClinicContext _healthContext;
        public ComentarioRepository() {
            _healthContext = new HealthClinicContext();
        }
        public void Cadastrar(Comentario comentario)
        {
            _healthContext.Comentario.Add(comentario);
            _healthContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {

            Comentario comentarioBuscado = _healthContext.Comentario.Find(id);
            _healthContext.Comentario.Remove(comentarioBuscado);
            _healthContext.SaveChanges();
        }

        public List<Comentario> Listar()
        {
            return _healthContext.Comentario.ToList();
        }
    }
}
