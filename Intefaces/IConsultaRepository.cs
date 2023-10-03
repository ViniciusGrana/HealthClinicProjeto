using HealthClinic.Domains;

namespace HealthClinic.Intefaces
{
    public interface IConsultaRepository
    {
        void Cadastrar(Consulta consulta);

        void Deletar(Guid id);

        List<Consulta> ListarMinhasMedico(Guid id);
        List<Consulta> ListarMinhasPaciente(Guid id);
        List<Consulta> Listar();

        Consulta BuscarPorId(Guid id);

        void Atualizar(Guid id, Consulta consulta);
    }
}
