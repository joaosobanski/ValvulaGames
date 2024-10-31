using Microsoft.Toolkit.Diagnostics;
using ValvulaGames.Domain.Entity.Game;


namespace ValvulaGames.Domain.Entity.Library;

public class Library
{
    public Library()
    {
    }


    // posso criar um jogo novo com id nulo. dentro a instrucao de adicioar o mesmo na biblioteca.

    // public Library(int accountId, ValvulaGames.Domain.Entity.Game.Game game)
    // {
    //     Guard.IsNotDefault(accountId, nameof(accountId));
    //     // Guard.IsNotDefault(gameId, nameof(gameId));

    //     AccountId = accountId;
    //     Game = game;
    //     // GameId = gameId;
    //     // CreatedAt = DateTime.Now;
    // }

    public Library(int accountId, int gameId)
    {
        Guard.IsNotDefault(accountId, nameof(accountId));
        Guard.IsNotDefault(gameId, nameof(gameId));

        AccountId = accountId;
        GameId = gameId;
        // CreatedAt = DateTime.Now;
    }

    public int AccountId { get; private set; }
    public int GameId { get; private set; }

    public Account.Account Account { get; private set; }

    public Game.Game Game { get; set; }

    // public DateTime CreatedAt { get; set; }
    // tempo jogo
    // archivary
    // comments
}
