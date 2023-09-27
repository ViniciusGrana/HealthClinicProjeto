using HealthClinic.Domains;

namespace HealthClinic.Intefaces
{
    public interface IEspecialidadeRepository
    {
        void Cadastrar(Especialidade especialidade);

        void Atualizar(Guid id, Especialidade especialidade);

        List<Especialidade> Listar();

        void Deletar(Guid id);  




    }
}
