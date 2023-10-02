using HealthClinic.Domains;

namespace HealthClinic.Intefaces
{
    public interface IComentarioRepository
    {
        void Cadastrar(Comentario comentario);

        List<Comentario> Listar();

        void Deletar(Guid id);

    }
}
