using EmprestimoLivros.Domain.Validation;

namespace EmprestimoLivros.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }

        public Usuario()
        {
        }

        public Usuario(int id, string? nome, string? email)
        {
            DomainExceptionValidation.When(id < 0, "Id não pode ser negativo");

            Id = id;
            ValidateDomain(nome, email);
        }

        public Usuario( string nome, string email)
        {
            ValidateDomain(nome, email);
        }

        public void AlterarSenha(byte[] passwordHash, byte[] passwordSalt)
        {
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
        }

        private void ValidateDomain(string nome, string email)
        {
            DomainExceptionValidation.When(nome == null, "Obrigatório informar o nome.");
            DomainExceptionValidation.When(email == null, "Obrigatório informar o e-mail.");
            DomainExceptionValidation.When(nome.Length > 250, "O nome não pode ultrapassar 250 caratcteres.");
            DomainExceptionValidation.When(email.Length > 250, "O e-mail não pode ultrapassar 250 caratcteres.");
        }
    }
}
