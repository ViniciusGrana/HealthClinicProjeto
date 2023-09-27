using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using webapihealthclinic.Domains;

namespace HealthClinic.Domains
{
    [Table(nameof(Consulta))]
    public class Consulta
    {
        [Key]
        public Guid IdConsulta { get; set; } = Guid.NewGuid();

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage ="A data de agendamento é obrigatória!")]
        public DateTime DataAgendamento { get; set; }

        [Column(TypeName = "VARCHAR (100)")]
        [Required(ErrorMessage = "A descrição é obrigatória!")]

        public string? Descricao { get; set; }

        //ref.tabela Paciente = FK
        [Required(ErrorMessage = "Informe o Paciente!")]
        public Guid IdPaciente { get; set; }

        [ForeignKey(nameof(IdPaciente))]
        public Paciente? Paciente { get; set; }

        //ref.tabela Medico = FK
        [Required(ErrorMessage = "Informe o Medico!")]
        public Guid IdMedico { get; set; }

        [ForeignKey(nameof(IdMedico))]
        public Medico? Medico { get; set; }


        //ref.tabela Comentario = FK
        [Required(ErrorMessage = "Informe o Comentario!")]
        public Guid IdComentario { get; set; }

        [ForeignKey(nameof(IdComentario))]
        public Comentario? Comentario { get; set; }

        //ref.tabela Prontuario = FK
        [Required(ErrorMessage = "Informe o Prontuario!")]
        public Guid IdProntuario { get; set; }

        [ForeignKey(nameof(IdProntuario))]
        public Prontuario? Prontuario { get; set; }
    }
}
