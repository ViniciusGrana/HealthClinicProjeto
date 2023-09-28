using HealthClinic.Domains;

namespace HealthClinic.Intefaces
{
    public interface IClinicaRepository
    {
        void Cadastrar(Clinica clinica);

        void Atualizar(Guid id, Clinica clinica);

        List<Clinica> Listar();

        void Deletar(Guid id);
    }
}
