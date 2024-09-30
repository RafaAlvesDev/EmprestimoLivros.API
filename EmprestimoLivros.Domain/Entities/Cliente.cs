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
        public string CliCpf { get; private set; }
        public string CliNome { get; private set; }
        public string CliEndereco { get; private set; }
        public string CliCidade { get; private set; }
        public string CliBairro { get; private set; }
        public string CliNumero { get; private set; }
        public string CliTelefoneCelular { get; private set; }
        public string ClitelefoneFixo { get; private set; }

        public ICollection<Livro_Cliente_Emprestimo> Emprestimos { get; private set; }  

        public Cliente(int id, string clicpf, string clinome, string cliendereco,
            string clicidade, string clibairro, string clinumero, string clitelefonecelular,
            string clitelefonefixo)
        {
            DomainExceptionValidation.When(id <= 0, "O ID deve ter maior do que zero.");

            Id = id;
            ValidationDomain(clicpf, clinome, cliendereco, clicidade, clibairro, clinumero, clitelefonecelular, clitelefonefixo);
        }

        public Cliente(string clicpf, string clinome, string cliendereco,
         string clicidade, string clibairro, string clinumero, string clitelefonecelular,
         string clitelefonefixo)
        {
            ValidationDomain(clicpf, clinome, cliendereco, clicidade, clibairro, clinumero, clitelefonecelular, clitelefonefixo);
        }

        public void Update(string clicpf, string clinome, string cliendereco,
        string clicidade, string clibairro, string clinumero, string clitelefonecelular,
        string clitelefonefixo)
        {
            ValidationDomain(clicpf, clinome, cliendereco, clicidade, clibairro, clinumero, clitelefonecelular, clitelefonefixo);
        }

        public void ValidationDomain(string clicpf, string clinome, string cliendereco,
            string clicidade, string clibairro, string clinumero, string clitelefonecelular,
            string clitelefonefixo)
        {
            DomainExceptionValidation.When(clicpf.Length != 11, "O CPF deve ter 11 caracteres.");
            DomainExceptionValidation.When(clinome.Length > 200, "O nome deve ter no máximo 200 caracteres.");
            DomainExceptionValidation.When(cliendereco.Length > 50, "O endereco deve ter no máximo 50 caracteres.");
            DomainExceptionValidation.When(clicidade.Length > 40, "A cidade deve ter no máximo 40 caracteres.");
            DomainExceptionValidation.When(clibairro.Length > 40, "O bairro deve ter no máximo 40 caracteres.");
            DomainExceptionValidation.When(clinumero.Length > 10, "O número deve ter no máximo 10 caracteres.");
            DomainExceptionValidation.When(clitelefonecelular.Length > 15, "O telefone celular deve ter no máximo 15 caracteres.");
            DomainExceptionValidation.When(clitelefonefixo.Length > 15, "O telefone fixo deve ter no máximo 15 caracteres.");

            CliCpf = clicpf;
            CliNome = clinome;
            CliEndereco = cliendereco;
            CliCidade = clicidade;
            CliBairro = clibairro;
            CliNumero = clinumero;
            CliTelefoneCelular = clitelefonecelular;
            ClitelefoneFixo = clitelefonefixo;
        }
    }
}

