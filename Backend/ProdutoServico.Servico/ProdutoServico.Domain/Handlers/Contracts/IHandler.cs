using ProdutoServico.Domain.Commands.Contracts;

namespace ProdutoServico.Domain.Handlers.Contracts
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}