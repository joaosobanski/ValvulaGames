using Microsoft.Toolkit.Diagnostics;

namespace ValvulaGames.Domain.Entity.Account;

public partial class Account
{
    public void IncreaseBalance(decimal value)
    {
        Guard.IsGreaterThan(value, 0, nameof(value));

        this.Balance += value;
    }

    public void DecreaseBalance(decimal value)
    {
        Guard.IsGreaterThan(value, 0, nameof(value));

        this.Balance -= value;

        Guard.IsGreaterThan(this.Balance, 0, nameof(this.Balance));
    }

    public void DecreaseBalanceRefundCase(decimal value)
    {
        Guard.IsGreaterThan(value, 0, nameof(value));

        this.Balance -= value;
    }

}