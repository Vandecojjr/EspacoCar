using ProdutoServico.Domain.Commands;
using ProdutoServico.Domain.Handlers;

namespace ProdutoServico.Domain.Teste.HandlerTestes
{
    [TestClass]
    public class CriarProdutoHandlerTestes
    {

        [TestMethod]
        public void Dado_um_comando_invalido_deve_interromper_a_execucao()
        {
            var comando = new CriarProdutoCommand("", 0, 0, 0);
            var manipulador = new ProdutoHandler(null);
            Assert.Fail();
        }
        [TestMethod]
        public void Dado_um_comando_valido_deve_criar_o_produto()
        {
            Assert.Fail();
        }
    }
}