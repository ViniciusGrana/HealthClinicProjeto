using HealthClinic.Domains;

namespace HealthClinic.Intefaces
{
    public interface IPacienteRepository
    {
        void Cadastrar(Paciente paciente);

        void Deletar(Guid id);

        List<Paciente> Listar();

       Paciente BuscarPorID(Guid id);
    }
}
