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
        public string LivroNome { get; set; }
        public string LivroAutor { get; set; }
        public string LivroEditora { get; set; }
        public DateTime? LivroAnoPublicacao { get; set; }
        public string LivroEdicao { get; set; }
        public virtual ICollection<Livro_Cliente_Emprestimo> Emprestimos { get; set; } = new List<Livro_Cliente_Emprestimo>();

        public Livro(int id, string livroNome, string livroAutor, string livroEditora,
            DateTime livroAnoPublicacao, string livroEdicao)
        {
            DomainExceptionValidation.When(id <= 0, "O ID deve ter maior do que zero.");

            Id = id;
            ValidationDomain(livroNome, livroAutor, livroEditora, livroAnoPublicacao, livroEdicao);
        }

        public Livro(string livroNome, string livroAutor, string livroEditora,
            DateTime livroAnoPublicacao, string livroEdicao)
        {
            ValidationDomain(livroNome, livroAutor, livroEditora, livroAnoPublicacao, livroEdicao);
        }

        public void Update(string livroNome, string livroAutor, string livroEditora,
            DateTime livroAnoPublicacao, string livroEdicao)
        {
            ValidationDomain(livroNome, livroAutor, livroEditora, livroAnoPublicacao, livroEdicao);
        }

        public void ValidationDomain(string livroNome, string livroAutor, string livroEditora,
            DateTime livroAnoPublicacao, string livroEdicao)
        {
            DomainExceptionValidation.When(livroNome.Length > 50, "O nome do livro deve ter no máximo 50 caracteres.");
            DomainExceptionValidation.When(livroAutor.Length > 200, "O nome do autor deve ter no máximo 200 caracteres.");
            DomainExceptionValidation.When(livroEditora.Length > 100, "O nome do editora deve ter no máximo 100 caracteres.");
            DomainExceptionValidation.When(livroEdicao.Length > 50, "A edição deve ter no máximo 50 caracteres.");

            LivroNome = livroNome;
            LivroAutor = livroAutor;
            LivroEditora = livroEditora;
            LivroAnoPublicacao = livroAnoPublicacao;
            LivroEdicao = livroEdicao;
        }
    }
}
