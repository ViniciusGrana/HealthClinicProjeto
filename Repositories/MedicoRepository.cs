using HealthClinic.Contexts;
using HealthClinic.Domains;
using HealthClinic.Intefaces;
using webapihealthclinic.Domains;

namespace HealthClinic.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly HealthClinicContext _healthClinicContext;
        public MedicoRepository()
        {
            _healthClinicContext = new HealthClinicContext();
        }

        public void Atualizar(Guid id, Medico medico)
        {
            try
            {
                Medico medicoBuscado = _healthClinicContext.Medico.FirstOrDefault(m => m.IdMedico == id)!;

                if (medicoBuscado != null)
                {
                    medicoBuscado.Especialidade = medico.Especialidade;
                    medicoBuscado.IdEspecialidade = medico.IdEspecialidade;

                }

                _healthClinicContext.Medico.Update(medicoBuscado!);

                _healthClinicContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Medico BuscarPorID(Guid id)
        {
            try
            {
                Medico medico = _healthClinicContext.Medico
                     .Select(m => new Medico
                     {
                         IdMedico = m.IdMedico,
                         IdUsuario = m.IdUsuario,

                         Usuario = new Usuario
                         {
                             IdUsuario = m.IdUsuario,
                             Email = m.Usuario!.Email,
                             Senha = m.Usuario!.Senha,
                             IdTipoUsuario = m.Usuario!.IdTipoUsuario,

                             TiposUsuario = new TiposUsuario
                             {
                                 IdTipoUsuario = m.Usuario.IdTipoUsuario,
                                 Titulo = m.Usuario.TiposUsuario!.Titulo
                             }
                         },

                         Especialidade = new Especialidade
                         {
                             IdEspecialidade = m.IdEspecialidade,
                             TituloEspecialidade = m.Especialidade!.TituloEspecialidade
                         },

                         IdClinica = m.IdClinica,
                         Clinca = new Clinica
                         {
                             IdClinica = m.IdClinica,
                             NomeFantasia = m.Clinca!.NomeFantasia,
                             CNPJ = m.Clinca!.CNPJ,
                             RazaoSocial = m.Clinca!.RazaoSocial,
                             Endereco = m.Clinca!.Endereco,
                         }


                     }).FirstOrDefault(p => p.IdMedico == id)!;

                if (medico != null)
                {
                    return medico;
                }
                return null!;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Medico medico)
        {
            try
            {
                _healthClinicContext.Add(medico);

                _healthClinicContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                Medico medicoBuscado = _healthClinicContext.Medico.FirstOrDefault(m => m.IdMedico == id)!;

                _healthClinicContext.Remove(medicoBuscado);

                _healthClinicContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Medico> Listar()
        {
            return _healthClinicContext.Medico.ToList();
        }
    }
}
