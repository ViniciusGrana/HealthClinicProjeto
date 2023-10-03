using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HealthClinic.Domains
{[Table(nameof(StatusConsulta))]
        
        public class StatusConsulta
        {
            [Key]
            public Guid IdStatusConsulta { get; set; } = Guid.NewGuid();

            [Column(TypeName = "VARCHAR(15)")]
            [Required(ErrorMessage = "Status obrigatório")]
            public string? Status { get; set; }
        }
    }
