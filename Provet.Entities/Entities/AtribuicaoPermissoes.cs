using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Provet.Entities.Entities
{
    [Table(name: "TB_ATRITUICAO_PERMISSOES")]
    public class AtribuicaoPermissoes
    {
        [Column("ATR_PERM_ID")]
        [Key]
        [Required]
        public int Id { get; set; }

        [Column("ATR_PERM_USUARIO_ID")]
        public virtual int UsuarioId { get; set; }

        [Column("ATR_PERM_PERFIL_ID")]
        public virtual int PerfilId { get; set; }

        [Column("ATR_PERM_CRIADO_EM")]
        public DateTime? CriadoEm { get; set; } = DateTime.UtcNow;

        [Column("ATR_PERM_ATUALIZADO_EM")]
        public DateTime? AtualizadoEm { get; set; }
    }
}
