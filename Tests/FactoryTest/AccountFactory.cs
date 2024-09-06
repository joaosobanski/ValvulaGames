
using Bogus;
using ValvulaGames.Domain.Entity.Account;

namespace ValvulaGames.Tests.Factory.AccountFactory;

public static class AccountFactory
{
    private static Faker<Account> ValidAccount()
    {
        return new Faker<Account>()
                   .RuleFor(u => u.Email, f => f.Internet.Email())
                   .RuleFor(e => e.Username, e => e.Internet.UserName())
                   .RuleFor(e => e.Slug, e => e.Person.FirstName)
                   .RuleFor(e => e.Password, e => e.Lorem.Word());
    }

    public static Account Valid()
    {
        return ValidAccount().Generate();
    }

    public static Account InvalidUsername()
    {
        var valid = ValidAccount();
        valid.RuleFor(e => e.Username, string.Empty);

        return valid.Generate();
    }

    public static Account InvalidEmail()
    {
        var valid = ValidAccount();
        valid.RuleFor(e => e.Email, string.Empty);

        return valid.Generate();
    }

    public static Account InvalidSlug()
    {
        var valid = ValidAccount();
        valid.RuleFor(e => e.Slug, string.Empty);

        return valid.Generate();
    }

    public static Account InvalidPassword()
    {
        var valid = ValidAccount();
        valid.RuleFor(e => e.Password, string.Empty);

        return valid.Generate();
    }

}
