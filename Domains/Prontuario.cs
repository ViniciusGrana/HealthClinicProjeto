using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic.Domains
{
    [Table(nameof(Prontuario))]
    public class Prontuario
    {
        [Key]

        public Guid IdProntuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR (100)")]
        [Required(ErrorMessage ="A descrição do prontuário é obrigatória!")]

        public string Descricao { get; set; }
    }
}
