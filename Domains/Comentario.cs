using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic.Domains
{
    [Table(nameof(Comentario))]
    public class Comentario
    {
        [Key]
        
        public Guid IdComentario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR (100)")]
        [Required(ErrorMessage ="O feedback é obrigatório!")]

        public string Feedback { get; set; }
    }
}
