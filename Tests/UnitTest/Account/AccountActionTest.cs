
using FluentAssertions;

namespace UnitTest;


public partial class AccountTest
{
    [TestCase(1)]
    [TestCase(10)]
    [TestCase(1000)]
    public void Deve_Incrementar_Balance(decimal valor)
    {
        Action act = () => _account.IncreaseBalance(valor);

        act.Should().NotThrow();
        _account.Balance.Should().Be(valor);
    }

    [TestCase(0)]
    [TestCase(-1)]
    public void Deve_Falhar_Ao_Incrementar_Balance(decimal valor)
    {
        Action act = () => _account.IncreaseBalance(valor);

        act.Should()
            .Throw<ArgumentException>()
            .WithMessage($"*value*");
    }

    [Test]
    public void Deve_Decrementar_Secund_Balance()
    {
        _account.IncreaseBalance(10);

        Action act = () => _account.DecreaseBalance(50);

        act.Should()
            .Throw<ArgumentException>()
            .WithMessage($"*balance*");
    }


}