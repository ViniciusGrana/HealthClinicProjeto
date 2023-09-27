using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic.Domains
{
    [Table(nameof(Usuario))]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage ="O nome do usuario é obrigatorio!")]
        public string? Nome { get; set; }

        [Column(TypeName ="VARCHAR (100)")]
        [Required(ErrorMessage ="O Email do usuario é obrigatório!")]
        public string? Email { get; set; }

        [Column(TypeName ="VARCHAR (100)")]
        [Required(ErrorMessage ="A Senha é obrigatório!")]
        public string? Senha { get; set; }


        //ref.tabela TiposUsuario = FK
        [Required(ErrorMessage = "Informe o tipo de usuario!")]
        public Guid IdTipoUsuario { get; set; }

        [ForeignKey(nameof(IdTipoUsuario))]
        public TiposUsuario? TiposUsuario { get; set; }
    }
}
