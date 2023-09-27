using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic.Domains
{
    [Table(nameof(Clinica))]
    public class Clinica
    {
        [Key]
        public Guid IdClinica { get; set; } = Guid.NewGuid();
        [Column(TypeName ="VARCHAR (100)")]
        [Required(ErrorMessage ="O Nome fantasia é obrigatório!")]
        public string NomeFantasia { get; set; }

        [Column(TypeName = "VARCHAR (100)")]
        [Required(ErrorMessage = "O endereço da clinica é obrigatório!")]
        public string Endereco { get; set; }
        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "O horario de abertura é obrigatório!")]
        public DateTime Abertura { get; set; }
        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "O horario de fechamento é obrigatório!")]
        public DateTime Fechamento { get; set; }
        [Column(TypeName = "VARCHAR (14)")]
        [Required(ErrorMessage = "O CNPJ da clínica é obrigatório!")]
        public string? CNPJ { get; set; }
        [Column(TypeName = "VARCHAR (100)")]
        [Required(ErrorMessage = "A razão socia é obrigatória!")]

        public string? RazaoSocial { get; set; }
    }
}
