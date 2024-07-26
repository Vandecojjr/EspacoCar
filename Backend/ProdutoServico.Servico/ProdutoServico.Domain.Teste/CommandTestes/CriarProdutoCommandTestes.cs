using ProdutoServico.Domain.Commands;

namespace ProdutoServico.Domain.Teste.CommandTestes;

[TestClass]
public class CriarProdutoCommandTestes
{
    private readonly CriarProdutoCommand _comandoInvalido = new(" ", 0, 0, 0);
    private readonly CriarProdutoCommand _comandoValido = new("Vela", 15, 10.00m, 50.00m);

    public CriarProdutoCommandTestes()
    {
        _comandoInvalido.Validate();
        _comandoValido.Validate();
    }

    [TestMethod]
    public void Dado_um_comando_invalido()
    {
        Assert.AreEqual(_comandoInvalido.Valid, false);
    }

    [TestMethod]
    public void Dado_um_comando_valido()
    {
        Assert.AreEqual(_comandoValido.Valid, true);
    }
}