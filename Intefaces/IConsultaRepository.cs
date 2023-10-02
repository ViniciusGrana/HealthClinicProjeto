using HealthClinic.Domains;

namespace HealthClinic.Intefaces
{
    public interface IConsultaRepository
    {
        void Cadastrar(Consulta consulta);

        void Atualizar(Guid id, Consulta consulta);

        List<Consulta> Listar();

        void Deletar(Guid id);



    }
}
