using Flunt.Notifications;
using Flunt.Validations;
using ProdutoServico.Domain.Commands.Contracts;

namespace ProdutoServico.Domain.Commands
{
    public class CriarProdutoCommand : Notifiable, ICommand
    {
        public CriarProdutoCommand() { }

        public CriarProdutoCommand(string nome, int estoque, decimal valorDeCusto, decimal preco)
        {
            Nome = nome;
            Estoque = estoque;
            ValorDeCusto = valorDeCusto;
            Preco = preco;
        }

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
                .IsGreaterOrEqualsThan(ValorDeCusto, 0, "ValorDeCusto", "O custo não pode ser negativo!")
                .IsGreaterOrEqualsThan(Preco, 0, "Preco", "O Preco não pode ser negativo!")
            );
        }

    }
}