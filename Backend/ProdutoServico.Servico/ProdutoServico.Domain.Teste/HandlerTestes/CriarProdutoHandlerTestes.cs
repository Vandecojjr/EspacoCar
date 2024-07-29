using ProdutoServico.Domain.Commands;
using ProdutoServico.Domain.Handlers;
using ProdutoServico.Domain.Teste.Repositories;

namespace ProdutoServico.Domain.Teste.HandlerTestes
{
    [TestClass]
    public class CriarProdutoHandlerTestes
    {
        private readonly CriarProdutoCommand _comandoInvalido = new(" ", 0, 0, 0);
        private readonly CriarProdutoCommand _comandoValido = new("Vela", 15, 10.00m, 50.00m);
        private readonly ProdutoHandler _manipulador = new ProdutoHandler(new FalsoProdutoRepository());
        private GenericoCommandResult _resultado = new GenericoCommandResult();

        [TestMethod]
        public void Dado_um_comando_invalido_deve_interromper_a_execucao()
        {
            _resultado = (GenericoCommandResult)_manipulador.Handle(_comandoInvalido);
            Assert.AreEqual(_resultado.Sucesso, false);
        }
        [TestMethod]
        public void Dado_um_comando_valido_deve_criar_o_produto()
        {
            _resultado = (GenericoCommandResult)_manipulador.Handle(_comandoValido);
            Assert.AreEqual(_resultado.Sucesso, true);
        }
    }
}