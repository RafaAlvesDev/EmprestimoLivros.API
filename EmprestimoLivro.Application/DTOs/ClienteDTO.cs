using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;

namespace EmprestimoLivro.Application.DTOs
{
    public class ClienteDTO
    {
        [IgnoreDataMember]
        public int Id { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF deve ter 11 caracteres.")]
        public string? CliCpf { get; set; }

        [StringLength(200, ErrorMessage = "O nome deve ter no máximo 200 caracteres.")]
        public string? CliNome { get; set; }

        [StringLength(50, ErrorMessage = "O endereco deve ter no máximo 50 caracteres.")]
        public string? CliEndereco { get; set; }

        [StringLength(40, ErrorMessage = "A cidade deve ter no máximo 40 caracteres.")]
        public string? CliCidade { get; set; }

        [StringLength(40, ErrorMessage = "O bairro deve ter no máximo 40 caracteres.")]
        public string? CliBairro { get; set; }

        [StringLength(10, ErrorMessage = "O número deve ter no máximo 10 caracteres.")]
        public string? CliNumero { get; set; }

        [StringLength(15, ErrorMessage = "O telefone celular deve ter no máximo 15 caracteres.")]
        public string? CliTelefoneCelular { get; set; }

        [StringLength(15, ErrorMessage = "O telefone fixo deve ter no máximo 15 caracteres.")]
        public string? ClitelefoneFixo { get; set; }
    }
}
