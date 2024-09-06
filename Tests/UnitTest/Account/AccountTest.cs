
using FluentAssertions;
using ValvulaGames.Domain.Entity.Account;
using ValvulaGames.Tests.Factory.AccountFactory;

namespace UnitTest;


public partial class AccountTest
{
    Account _account;

    [SetUp]
    public void SetUp()
    {
        _account = AccountFactory.Valid();
    }

    [Test]
    public void Deve_Criar_Account_Sucesso()
    {
        var account = new Account(_account.Username, _account.Password, _account.Email, _account.Slug);

        account.Should().NotBeNull();
        account.Username.Should().NotBeNull();
        account.Password.Should().NotBeNull();
        account.Email.Should().NotBeNull();
        account.Slug.Should().NotBeNull();
        account.Balance.Should().Be(0);
    }

    [Test]
    public void Deve_Falhar_Account_Username()
    {
        _account = AccountFactory.InvalidUsername();

        Action act = () => new Account(_account.Username, _account.Password, _account.Email, _account.Slug);

        act.Should()
            .Throw<ArgumentException>()
            .WithMessage($"*username*");
    }

    [Test]
    public void Deve_Falhar_Account_Email()
    {
        _account = AccountFactory.InvalidEmail();

        Action act = () => new Account(_account.Username, _account.Password, _account.Email, _account.Slug);

        act.Should()
            .Throw<ArgumentException>()
            .WithMessage($"*email*");
    }

    [Test]
    public void Deve_Falhar_Account_Com_Password_Invalido()
    {
        _account = AccountFactory.InvalidPassword();

        Action act = () => new Account(_account.Username, _account.Password, _account.Email, _account.Slug);

        act.Should()
            .Throw<ArgumentException>()
            .WithMessage($"*password*");
    }

    [Test]
    public void Deve_Falhar_Account_Slug()
    {
        _account = AccountFactory.InvalidSlug();

        Action act = () => new Account(_account.Username, _account.Password, _account.Email, _account.Slug);

        act.Should()
            .Throw<ArgumentException>()
            .WithMessage($"*slug*");
    }


}