using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Provet.Entities.Entities
{
    [Table(name: "TB_PERFIL")]
    public class Perfil
    {
        [Column("PERF_ID")]
        [Key]
        [Required]
        public int Id { get; set; }

        [Column("PERF_NOME")]
        [Required(ErrorMessage = "Nome é obrigatório")]
        [MinLength(3)]
        public string Nome { get; set; }

        [Column("PERF_LISTAR")]
        public bool Listar { get; set; }

        [Column("PERF_CONSULTAR")]
        public bool Consultar { get; set; }

        [Column("PERF_INSERIR")]
        public bool Inserir { get; set; }

        [Column("PERF_ATUALIZAR")]
        public bool Atualizar { get; set; }

        [Column("PERF_DELETAR")]
        public bool Deletar { get; set; }

        [Column("PERF_USUARIO_ID")]
        public int UsuarioId { get; set; }

        public Usuario? usuario { get; set; }

        [Column("PERF_CRIADO_EM")]
        public DateTime? CriadoEm { get; set; } = DateTime.UtcNow;

        [Column("PERF_ATUALIZADO_EM")]
        public DateTime? AtualizadoEm { get; set; }
    }
}
