using Microsoft.EntityFrameworkCore;
using ValvulaGames.Domain.Entity;
using ValvulaGames.Domain.Entity.Account;
using ValvulaGames.Domain.Entity.Game;
using ValvulaGames.Domain.Entity.Library;

namespace Infrastructure;

public class BancoContext : DbContext
{
    public BancoContext()
    {
        // Database.EnsureCreated();
    }

    public DbSet<Account> Accounts { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<Library> Libraries { get; set; }

    public DbSet<Transaction> Transactions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


        #region account
        modelBuilder.Entity<Account>()
            .ToTable("accounts")
            .HasKey(c => c.Id);

        modelBuilder.Entity<Account>()
            .Property(entidade => entidade.Username)
            .HasColumnType("VARCHAR(200)");

        modelBuilder.Entity<Account>()
            .Property(entidade => entidade.Password)
            .HasColumnType("VARCHAR(200)");

        modelBuilder.Entity<Account>()
            .Property(entidade => entidade.Slug)
            .HasColumnType("VARCHAR(200)");

        modelBuilder.Entity<Account>()
            .Property(entidade => entidade.Email)
            .HasColumnType("VARCHAR(200)");
        #endregion

        #region Game

        modelBuilder.Entity<Game>()
            .ToTable("games").HasKey(e => e.Id);

        #endregion

        #region Library

        modelBuilder.Entity<Library>()
            .ToTable("libraries");

        modelBuilder.Entity<Library>()
            .HasKey(l => new { l.AccountId, l.GameId });

        // modelBuilder.Entity<Library>()
        //     .HasOne(l => l.Game)
        //     .WithMany(g => g.Libraries)
        //     .HasForeignKey(l => l.GameId)
        //     .HasConstraintName("pk_library_game");
        // modelBuilder.Entity<Library>()
        //     .HasOne(l => l.Account)
        //     .WithMany(g => g.Libraries)
        //     .HasForeignKey(l => l.AccountId)
        //     .HasConstraintName("pk_library_account");

        #endregion


        
        #region transaction

        modelBuilder.Entity<ValvulaGames.Domain.Entity.Transaction>()
            .ToTable("transactions")
            .HasKey(c => c.Id);


        modelBuilder.Entity<Transaction>()
            .HasOne(l => l.Account)
            .WithMany(g => g.Transactions)
            .HasForeignKey(l => l.AccountId)
            .HasConstraintName("FK_TRANSACTIONS_ACCOUNT");
        modelBuilder.Entity<Transaction>()
            .HasOne(l => l.AccountOwner)
            .WithMany(g => g.OwnerOfTransactions)
            .HasForeignKey(l => l.OwnerAccountId)
            .HasConstraintName("FK_TRANSACTIONS_ACCOUNT_OWNER");

        #endregion
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder.UseSqlite("Data Source=meuBanco.db");
        optionsBuilder.UseNpgsql("Host=localhost;Database=teste1234;Username=postgres;Password=123");
    }
}
