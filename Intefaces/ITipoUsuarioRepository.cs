using HealthClinic.Domains;

namespace HealthClinic.Intefaces
{
        public interface ITipoUsuarioRepository
        {
            void Cadastrar(TiposUsuario tipoUsuario);

            void Deletar(Guid id);

            List<TiposUsuario> Listar();

            TiposUsuario BuscarPorID(Guid id);

            void Atualizar(Guid id, TiposUsuario tipoUsuario);

        }
    }
