using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmprestimoLivros.Domain.Validation;

namespace EmprestimoLivros.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; private set; }
        public string? CliCpf { get; private set; }
        public string? CliNome { get; private set; }
        public string? CliEndereco { get; private set; }
        public string? CliCidade { get; private set; }
        public string? CliBairro { get; private set; }
        public string? CliNumero { get; private set; }
        public string? CliTelefoneCelular { get; private set; }
        public string? ClitelefoneFixo { get; private set; }

        public ICollection<Livro_Cliente_Emprestimo>? Emprestimos { get; private set; }

        public Cliente() { }

        public Cliente(int Id, string CliCpf, string CliNome, string CliEndereco,
            string CliCidade, string CliBairro, string CliNumero, string CliTelefoneCelular,
            string ClitelefoneFixo)
        {
            DomainExceptionValidation.When(Id <= 0, "O ID deve ter maior do que zero.");

            this.Id = Id;
            ValidationDomain(CliCpf, CliNome, CliEndereco, CliCidade, CliBairro, CliNumero, CliTelefoneCelular, ClitelefoneFixo);
        }

        public Cliente(string CliCpf, string CliNome, string CliEndereco,
         string CliCidade, string CliBairro, string CliNumero, string CliTelefoneCelular,
         string ClitelefoneFixo)
        {
            ValidationDomain(CliCpf, CliNome, CliEndereco, CliCidade, CliBairro, CliNumero, CliTelefoneCelular, ClitelefoneFixo);
        }

        public void Update(string clicpf, string CliNome, string CliEndereco,
        string CliCidade, string CliBairro, string CliNumero, string CliTelefoneCelular,
        string ClitelefoneFixo)
        {
            ValidationDomain(clicpf, CliNome, CliEndereco, CliCidade, CliBairro, CliNumero, CliTelefoneCelular, ClitelefoneFixo);
        }

        public void ValidationDomain(string CliCpf, string CliNome, string CliEndereco,
            string CliCidade, string CliBairro, string CliNumero, string CliTelefoneCelular,
            string ClitelefoneFixo)
        {
            DomainExceptionValidation.When(CliCpf.Length != 11, "O CPF deve ter 11 caracteres.");
            DomainExceptionValidation.When(CliNome.Length > 200, "O nome deve ter no máximo 200 caracteres.");
            DomainExceptionValidation.When(CliEndereco.Length > 50, "O endereco deve ter no máximo 50 caracteres.");
            DomainExceptionValidation.When(CliCidade.Length > 40, "A cidade deve ter no máximo 40 caracteres.");
            DomainExceptionValidation.When(CliBairro.Length > 40, "O bairro deve ter no máximo 40 caracteres.");
            DomainExceptionValidation.When(CliNumero.Length > 10, "O número deve ter no máximo 10 caracteres.");
            DomainExceptionValidation.When(CliTelefoneCelular.Length > 15, "O telefone celular deve ter no máximo 15 caracteres.");
            DomainExceptionValidation.When(ClitelefoneFixo.Length > 15, "O telefone fixo deve ter no máximo 15 caracteres.");

            this.CliCpf = CliCpf;
            this.CliNome = CliNome;
            this.CliEndereco = CliEndereco;
            this.CliCidade = CliCidade;
            this.CliBairro = CliBairro;
            this.CliNumero = CliNumero;
            this.CliTelefoneCelular = CliTelefoneCelular;
            this.ClitelefoneFixo = ClitelefoneFixo;
        }
    }
}

