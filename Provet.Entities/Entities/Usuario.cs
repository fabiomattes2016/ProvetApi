using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Provet.Entities.Entities
{
    [Table(name: "TB_USUARIO")]
    public class Usuario
    {
        [Column("USU_ID")]
        [Key]
        [Required]
        public int Id { get; set; }

        [Column("USU_NOME")]
        [Required(ErrorMessage = "Nome é obrigatório")]
        [MinLength(3)]
        public string Nome { get; set; }

        [Column("USU_USUARIO")]
        [Required(ErrorMessage = "Nome de usuário é obrigatório")]
        [MinLength(3)]
        public string NomeUsuario { get; set; }

        [Column("USU_SENHA")]
        [Required(ErrorMessage = "Senha é obrigatório")]
        [MinLength(3)]
        public string Senha { get; set; }

        public ICollection<Perfil>? Perfis { get; set; }
        //public int PerfilId { get; set; }

        [Column("USU_CRIADO_EM")]
        public DateTime? CriadoEm { get; set; } = DateTime.UtcNow;

        [Column("USU_ATUALIZADO_EM")]
        public DateTime? AtualizadoEm { get; set; }
    }
}
