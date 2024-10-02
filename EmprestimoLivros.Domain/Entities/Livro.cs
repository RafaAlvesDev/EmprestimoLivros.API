using EmprestimoLivros.Domain.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprestimoLivros.Domain.Entities
{
    public class Livro
    {
        public int Id { get; private set; }
        public string? LivroNome { get; set; }
        public string? LivroAutor { get; set; }
        public string? LivroEditora { get; set; }
        public DateTime? LivroAnoPublicacao { get; set; }
        public string? LivroEdicao { get; set; }
        public virtual ICollection<Livro_Cliente_Emprestimo>? Emprestimos { get; set; } = new List<Livro_Cliente_Emprestimo>();

        public Livro() { }

        public Livro(int Id, string LivroNome, string LivroAutor, string LivroEditora,
            DateTime LivroAnoPublicacao, string LivroEdicao)
        {
            DomainExceptionValidation.When(Id <= 0, "O ID deve ter maior do que zero.");

            this.Id = Id;
            ValidationDomain(LivroNome, LivroAutor, LivroEditora, LivroAnoPublicacao, LivroEdicao);
        }

        public Livro(string LivroNome, string LivroAutor, string LivroEditora,
            DateTime LivroAnoPublicacao, string LivroEdicao)
        {
            ValidationDomain(LivroNome, LivroAutor, LivroEditora, LivroAnoPublicacao, LivroEdicao);
        }

        public void Update(string LivroNome, string LivroAutor, string LivroEditora,
            DateTime LivroAnoPublicacao, string LivroEdicao)
        {
            ValidationDomain(LivroNome, LivroAutor, LivroEditora, LivroAnoPublicacao, LivroEdicao);
        }

        public void ValidationDomain(string LivroNome, string LivroAutor, string LivroEditora,
            DateTime LivroAnoPublicacao, string LivroEdicao)
        {
            DomainExceptionValidation.When(LivroNome.Length > 50, "O nome do livro deve ter no máximo 50 caracteres.");
            DomainExceptionValidation.When(LivroAutor.Length > 200, "O nome do autor deve ter no máximo 200 caracteres.");
            DomainExceptionValidation.When(LivroEditora.Length > 100, "O nome do editora deve ter no máximo 100 caracteres.");
            DomainExceptionValidation.When(LivroEdicao.Length > 50, "A edição deve ter no máximo 50 caracteres.");

            this.LivroNome = LivroNome;
            this.LivroAutor = LivroAutor;
            this.LivroEditora = LivroEditora;
            this.LivroAnoPublicacao = LivroAnoPublicacao;
            this.LivroEdicao = LivroEdicao;
        }
    }
}
