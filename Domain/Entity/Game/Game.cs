
using Microsoft.Toolkit.Diagnostics;

namespace ValvulaGames.Domain.Entity.Game;


public class Game
{
    public Game()
    {
    }

    public Game(string name, decimal price)
    {
        Guard.IsNotNullOrWhiteSpace(name, nameof(name));
        Guard.IsNotDefault(price, nameof(price));
        Guard.IsGreaterThan(price, 0, nameof(price));

        Name = name;
        Price = price;
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public ICollection<Library.Library>? Libraries { get; private set; }
}