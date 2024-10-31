

using Microsoft.Toolkit.Diagnostics;
using ValvulaGames.Domain.Entity.Account;
using ValvulaGames.Domain.Entity.Game;

namespace ValvulaGames.Domain.Entity;


public class Transaction
{
    public Transaction()
    {
    }

    public Transaction(Account.Account account, Game.Game game, int status, Account.Account accountOwner)
    {
        Guard.IsNotNull(account, nameof(account));
        Guard.IsNotNull(accountOwner, nameof(accountOwner));
        Guard.IsNotNull(game, nameof(game));
        Guard.IsNotDefault(status, nameof(status));

        Account = account;
        Value = game.Price;
        Status = status;
        AccountOwner = accountOwner;
        
        accountOwner.DecreaseBalance(Value);
        var lib = new Library.Library(account.Id, game.Id);
        account.Libraries.Add(lib);
    }



    public int Id { get; private set; }
    // public DateTime DataCompra { get; private set; }
    public int AccountId { get; private set; }
    public int OwnerAccountId { get; private set; }
    public Account.Account Account { get; private set; }
    public decimal Value { get; private set; }
    public int Status { get; private set; }// 1  = compra / 2 = estorno / 3 = compra presente
    public Account.Account AccountOwner { get; private set; }

}



