using ProdutoServico.Domain.Commands.Contracts;

namespace ProdutoServico.Domain.Commands
{
    public class GenericoCommandResult : ICommandResult
    {
        public GenericoCommandResult()
        {
        }

        public GenericoCommandResult(bool sucesso, string mensagem, object dados)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
            Dados = dados;
        }

        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public object Dados { get; set; }

    }
}