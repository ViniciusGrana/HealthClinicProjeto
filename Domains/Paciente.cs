using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic.Domains
{
    [Table(nameof(Paciente))]
    public class Paciente
    {
        [Key]
        public Guid? IdPaciente { get; set; } = Guid.NewGuid();
        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "A data de nascimento é obrigatório!")]
        public DateTime? DataNascimento { get; set; }
        [Column(TypeName = "VARCHAR (11)")]
        [Required(ErrorMessage = "O numero de telefone é obrigatório!")]
        public string? Telefone { get; set; }
        [Column(TypeName = "VARCHAR (8)")]
        [Required(ErrorMessage = "O RG é obrigatório!")]
        public string? RG { get; set; }
        [Column(TypeName = "VARCHAR (11)")]
        [Required(ErrorMessage = "O CPF é obrigatório!")]
        public string? CPF { get; set; }
        [Column(TypeName = "VARCHAR (100)")]
        [Required(ErrorMessage = "O Endereço é obrigatório!")]

        public string? Endereco { get; set; }

        //ref.tabela Usuario = FK
        [Required(ErrorMessage = "Informe o usuario!")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }
    }
}
