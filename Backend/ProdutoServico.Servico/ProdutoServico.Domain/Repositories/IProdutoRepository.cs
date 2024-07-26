using ProdutoServico.Domain.Entities;

namespace ProdutoServico.Domain.Repositories
{
    public interface IProdutoRepository
    {
        void Criar(Produto produto);
        void Atualizar(Produto produto);

    }
}