using EmprestimoLivros.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprestimoLivros.Domain.Entities
{
    public class Livro_Cliente_Emprestimo
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdLivro { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataEntrega { get; set; }
        public bool Entregue { get; set; }

        public Cliente? Cliente { get; set; }
        public Livro? Livro { get; set; }

        public Livro_Cliente_Emprestimo(int id, int idCliente, int idLivro, DateTime dataEmprestimo,
            DateTime dataEntrega, bool entregue)
        {
            DomainExceptionValidation.When(id <= 0, "O ID deve ter maior do que zero.");

            Id = id;
            ValidationDomain(idCliente, idLivro, dataEmprestimo, dataEntrega, entregue);
        }

        public Livro_Cliente_Emprestimo(int idCliente, int idLivro, DateTime dataEmprestimo, DateTime dataEntrega, bool entregue)
        {
            ValidationDomain(idCliente, idLivro, dataEmprestimo, dataEntrega, entregue);
        }

        public void Update(int idCliente, int idLivro, DateTime dataEmprestimo, DateTime dataEntrega, bool entregue)
        {
            ValidationDomain(idCliente, idLivro, dataEmprestimo, dataEntrega, entregue);
        }

        public void ValidationDomain(int idCliente, int idLivro,
            DateTime dataEmprestimo, DateTime dataEntrega, bool entregue)
        {
            DomainExceptionValidation.When(idCliente <= 0, "Id do cliente deve ter maior do que zero.");
            DomainExceptionValidation.When(idLivro <= 0, "Id do livro deve ter maior do que zero.");

            IdCliente = idCliente;
            IdLivro = idLivro;
            DataEmprestimo = dataEmprestimo;
            DataEntrega = dataEntrega;
            Entregue = entregue;
        }
    }
}
