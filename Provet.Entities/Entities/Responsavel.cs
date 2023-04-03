using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Provet.Entities.Entities
{
    [Table(name: "TB_RESPONSAVEL")]
    public class Responsavel
    {
        [Column("RESP_ID")]
        [Key]
        [Required]
        public int Id { get; set; }

        [Column("RESP_NOME")]
        [Required(ErrorMessage = "Nome é obrigatório")]
        [MinLength(3)]
        public string Nome { get; set; }

        [Column("RESP_CPF")]
        [Required(ErrorMessage = "CPF é obrigatório")]
        [MinLength(11, ErrorMessage = "CPF deve conter no minímo 11 caracteres")]
        [MaxLength(14, ErrorMessage = "CPF deve conter no máximo 14 caracteres")]
        public string Cpf { get; set; }

        [Column("RESP_RG")]
        public string? Rg { get; set; }

        [Column("RESP_ENDERECO")]
        [Required(ErrorMessage = "Endereco é obrigatório")]
        [MinLength(5)]
        public string Endereco { get; set; }

        [Column("RESP_NUMERO")]
        public string? Numero { get; set; }

        [Column("RESP_BAIRRO")]
        public string? Bairro { get; set; }

        [Column("RESP_CIDADE")]
        [Required(ErrorMessage = "Cidade é obrigatório")]
        [MinLength(5)]
        public string Cidade { get; set; }

        [Column("RESP_CEP")]
        [Required(ErrorMessage = "CEP é obrigatório")]
        [MinLength(8, ErrorMessage = "CEP deve conter no minímo 8 caracteres")]
        [MaxLength(10, ErrorMessage = "CEP deve conter no máximo 10 caracteres")]
        public string Cep { get; set; }

        [Column("RESP_ESTADO")]
        [Required(ErrorMessage = "Estado é obrigatório")]
        public string Estado { get; set; }

        [Column("RESP_DATA_NASCIMENTO")]
        [Required(ErrorMessage = "Data de Nascimento é obrigatório")]
        public DateTime DataNascimento { get; set; }

        [Column("RESP_TELEFONE")]
        public string? Telefone { get; set; }

        [Column("RESP_CELULAR")]
        [Required(ErrorMessage = "Celular é obrigatório")]
        [MinLength(11, ErrorMessage = "Celular deve conter no minímo 11 caracteres")]
        [MaxLength(15, ErrorMessage = "Celular deve conter no máximo 15 caracteres")]
        public string Celular { get; set; }

        [Column("RESP_EMAIL")]
        public string? Email { get; set; }

        [Column("RESP_OBERVACAO")]
        public string? Observacao { get; set; }

        [Column("RESP_CRIADO_EM")]
        public DateTime? CriadoEm { get; set; } = DateTime.UtcNow;

        [Column("RESP_ATUALIZADO_EM")]
        public DateTime? AtualizadoEm { get; set; }
    }
}
