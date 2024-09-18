using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Cliente(int id, string clicpf, string clinome, string cliendereco,
            string clicidade, string clibairro, string clinumero, string clitelefonecelular,
            string clitelefonefixo)
        {
            Id = id;
            ValidationDomain(clicpf, clinome, cliendereco, clicidade, clibairro, clinumero, clitelefonecelular, clitelefonefixo);
        }

        public void ValidationDomain(string clicpf, string clinome, string cliendereco,
            string clicidade, string clibairro, string clinumero, string clitelefonecelular,
            string clitelefonefixo)
        {
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

