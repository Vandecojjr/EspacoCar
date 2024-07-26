using Flunt.Notifications;
using ProdutoServico.Domain.Commands;
using ProdutoServico.Domain.Commands.Contracts;
using ProdutoServico.Domain.Entities;
using ProdutoServico.Domain.Handlers.Contracts;
using ProdutoServico.Domain.Repositories;

namespace ProdutoServico.Domain.Handlers
{
    public class ProdutoHandler :
        Notifiable,
        IHandler<CriarProdutoCommand>
    {
        private readonly IProdutoRepository _repository;

        public ProdutoHandler(IProdutoRepository repository)
        {
            _repository = repository;
        }


        public ICommandResult Handle(CriarProdutoCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericoCommandResult(false, "Algo deu errado!", command.Notifications);

            var produto = new Produto(command.Nome, command.Estoque, command.ValorDeCusto, command.Preco);

            _repository.Criar(produto);

            return new GenericoCommandResult(true, "Produto criado com sucesso!", produto);
        }
    }
}