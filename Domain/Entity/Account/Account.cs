
using Microsoft.Toolkit.Diagnostics;

namespace ValvulaGames.Domain.Entity.Account;

public partial class Account
{
    public Account(string username, string password, string email, string slug)
    {
        Guard.IsNotNullOrWhiteSpace(username, nameof(username));
        Guard.IsNotNullOrWhiteSpace(password, nameof(password));
        Guard.IsNotNullOrWhiteSpace(email, nameof(email));
        Guard.IsNotNullOrWhiteSpace(slug, nameof(slug));

        Username = username;
        Password = password;
        Email = email;
        Slug = slug;
        Balance = 0;
    }

    public Account()
    {
        // EntityFramework
    }

    public int Id { get; private set; }

    public string Username { get; private set; }

    public string Password { get; private set; }

    public string Email { get; private set; }

    public string Slug { get; private set; }

    public decimal Balance { get; private set; }

}