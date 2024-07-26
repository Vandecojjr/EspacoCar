using Flunt.Notifications;
using Flunt.Validations;
using ProdutoServico.Domain.Commands.Contracts;

namespace ProdutoServico.Domain.Commands
{
    public class AtualizarProdutoCommand : Notifiable, ICommand
    {
        public AtualizarProdutoCommand() { }


        public AtualizarProdutoCommand(Guid id, string nome, int estoque, decimal valorDeCusto, decimal preco)
        {
            Id = id;
            Nome = nome;
            Estoque = estoque;
            ValorDeCusto = valorDeCusto;
            Preco = preco;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Estoque { get; set; }
        public decimal ValorDeCusto { get; set; }
        public decimal Preco { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(Nome, 3, "Nome", "O nome do produto deve ter mais de 3 caracteres!")
                .IsLowerThan(ValorDeCusto, 0, "ValorDeCusto", "O custo não pode ser negativo!")
                .IsLowerThan(Preco, 0, "Preco", "O Preco não pode ser negativo!")
            );
        }
    }
}