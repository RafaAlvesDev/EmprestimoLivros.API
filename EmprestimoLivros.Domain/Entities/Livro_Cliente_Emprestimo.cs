using EmprestimoLivros.Domain.Validation;

namespace EmprestimoLivros.Domain.Entities
{
    public class Livro_Cliente_Emprestimo
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdLivro { get; set; }
        public DateTime? DataEmprestimo { get; set; }
        public DateTime? DataEntrega { get; set; }
        public bool? Entregue { get; set; }

        public Cliente? Cliente { get; set; }
        public Livro? Livro { get; set; }

        public Livro_Cliente_Emprestimo() { }

        public Livro_Cliente_Emprestimo(int Id, int IdCliente, int IdLivro, DateTime DataEmprestimo,
            DateTime DataEntrega, bool Entregue)
        {
            DomainExceptionValidation.When(Id <= 0, "O ID deve ter maior do que zero.");

            this.Id = Id;
            ValidationDomain(IdCliente, IdLivro, DataEmprestimo, DataEntrega, Entregue);
        }

        public Livro_Cliente_Emprestimo(int IdCliente, int IdLivro, DateTime DataEmprestimo, DateTime DataEntrega, bool Entregue)
        {
            ValidationDomain(IdCliente, IdLivro, DataEmprestimo, DataEntrega, Entregue);
        }

        public void Update(int IdCliente, int IdLivro, DateTime DataEmprestimo, DateTime DataEntrega, bool Entregue)
        {
            ValidationDomain(IdCliente, IdLivro, DataEmprestimo, DataEntrega, Entregue);
        }

        public void ValidationDomain(int IdCliente, int IdLivro,
            DateTime DataEmprestimo, DateTime DataEntrega, bool Entregue)
        {
            DomainExceptionValidation.When(IdCliente <= 0, "Id do cliente deve ter maior do que zero.");
            DomainExceptionValidation.When(IdLivro <= 0, "Id do livro deve ter maior do que zero.");

            this.IdCliente = IdCliente;
            this.IdLivro = IdLivro;
            this.DataEmprestimo = DataEmprestimo;
            this.DataEntrega = DataEntrega;
            this.Entregue = Entregue;
        }
    }
}
