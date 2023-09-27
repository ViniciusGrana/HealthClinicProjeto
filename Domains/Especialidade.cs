using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic.Domains
{
    [Table(nameof(Especialidade))]
    public class Especialidade
    {
        [Key]
        public Guid IdEspecialidae { get; set; } = Guid.NewGuid();
        [Column(TypeName = "VARCHAR (100)")]
        [Required(ErrorMessage ="O titulo da especialidade é obrigatório!")]

        public string TituloEspecialidade { get; set; }
    }
}
