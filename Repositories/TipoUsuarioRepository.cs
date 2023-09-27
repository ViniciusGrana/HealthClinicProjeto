using HealthClinic.Contexts;
using HealthClinic.Domains;
using HealthClinic.Intefaces;

namespace HealthClinic.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        private readonly HealthClinicContext _healthContext;

        public TipoUsuarioRepository()
        {
            _healthContext = new HealthClinicContext();
        }

        public void Atualizar(Guid id, TiposUsuario tipoUsuario)
        {
            TiposUsuario tipoUsuarioBuscado = _healthContext.TiposUsuario.Find(id)!;

            if (tipoUsuarioBuscado != null)
            {
                tipoUsuarioBuscado.Titulo = tipoUsuario.Titulo;
            }

            _healthContext.TiposUsuario.Update(tipoUsuarioBuscado!);

            _healthContext.SaveChanges();
        }

        public TiposUsuario BuscarPorID(Guid id)
        {
            return _healthContext.TiposUsuario.FirstOrDefault(e => e.IdTipoUsuario == id)!;
        }

        public void Cadastrar(TiposUsuario tipoUsuario)
        {
            _healthContext.TiposUsuario.Add(tipoUsuario);

            _healthContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            TiposUsuario TipoBuscado = _healthContext.TiposUsuario.Find(id);
            _healthContext.TiposUsuario.Remove(TipoBuscado);
            _healthContext.SaveChanges();
        }

        public List<TiposUsuario> Listar()
        {
            return _healthContext.TiposUsuario.ToList();
        }
    }
}
