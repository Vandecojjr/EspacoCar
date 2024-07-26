namespace ProdutoServico.Domain.Entities
{
    public class Produto : Entity
    {
        public Produto(string nome, int estoque, decimal valorDeCusto, decimal preco)
        {
            Nome = nome;
            Estoque = estoque;
            ValorDeCusto = valorDeCusto;
            Preco = preco;
        }

        public int Number { get; private set; }
        public string Nome { get; private set; }
        public int Estoque { get; private set; }
        public decimal ValorDeCusto { get; private set; }
        public decimal Preco { get; private set; }

        public void AtualizarNome(string nome)
        {
            Nome = nome;
        }

        public void AtualizarEstoque(int estoque)
        {
            Estoque = estoque;
        }

        public void AtualizarValorDeCusto(decimal valorDeCusto)
        {
            ValorDeCusto = valorDeCusto;
        }

        public void AtualizarPreco(decimal preco)
        {
            Preco = preco;
        }
    }

}