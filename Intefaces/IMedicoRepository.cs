using HealthClinic.Domains;
using webapihealthclinic.Domains;

namespace HealthClinic.Intefaces
{
    public interface IMedicoRepository
    {
        void Cadastrar(Medico medico);

        void Deletar(Guid id);

        List<Medico> Listar();

        Medico BuscarPorID(Guid id);
    }
}
