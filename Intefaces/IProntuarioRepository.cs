using HealthClinic.Domains;

namespace HealthClinic.Intefaces
{
    public interface IProntuarioRepository
    {
        void Cadastrar(Prontuario prontuario);

        void Atualizar(Guid id, Prontuario prontuario);

        List<Prontuario> Listar();

        void Deletar(Guid id);
    }
}
