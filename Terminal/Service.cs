using System;
using System.Collections.Generic;
using System.Linq;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using ValvulaGames.Domain.Entity;
using ValvulaGames.Domain.Entity.Account;
using ValvulaGames.Domain.Entity.Game;
using ValvulaGames.Domain.Entity.Library;

public class Service
{
    private readonly BancoContext _context;

    public Service(BancoContext context)
    {
        _context = context;
    }

    // Método para criar uma conta
    public void CreateAccount(string username, string password, string email, string slug)
    {
        var account = new Account(username, password, email, slug);
        _context.Accounts.Add(account);
        _context.SaveChanges();
    }

    // Método para listar todas as contas
    public List<Account> GetAllAccounts()
    {
        return _context.Accounts
            .Include(acc => acc.Libraries)
            .Include(acc => acc.Transactions)
            .ToList();
    }

    // Método para adicionar saldo a uma conta
    public void AddBalance(int accountId, decimal amount)
    {
        var account = _context.Accounts.Find(accountId);
        if (account != null)
        {
            account.IncreaseBalance(amount);
            _context.SaveChanges();
        }
    }

    // Método para criar um jogo
    public void CreateGame(string title, decimal price)
    {
        var game = new Game(title, price);
        _context.Games.Add(game);
        _context.SaveChanges();
    }

    // Método para listar todos os jogos
    public List<Game> GetAllGames()
    {
        return _context.Games.ToList();
    }

    // Método para adicionar um jogo à biblioteca de um usuário
    public void AddGameToLibrary(int accountId, int gameId)
    {
        var account = _context.Accounts
            .Include(acc => acc.Libraries)
            .FirstOrDefault(acc => acc.Id == accountId);

        if (account != null)
        {
            var libraryEntry = new Library(accountId, gameId);
            account.Libraries.Add(libraryEntry);
            _context.SaveChanges();
        }
    }

    // Método para criar uma transação
    public void CreateTransaction(int ownerId, int receiverId, int gameId)
    {
        var owner = _context.Accounts.Find(ownerId);
        var receiver = _context.Accounts.Find(receiverId);
        var game = _context.Games.Find(gameId);

        if (owner != null && receiver != null && game != null)
        {
            var transaction = new Transaction(owner, game, 1, receiver);
            _context.Transactions.Add(transaction);
            _context.SaveChanges();
        }
    }
}
