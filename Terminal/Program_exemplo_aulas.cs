// using Infrastructure;
// using Microsoft.EntityFrameworkCore;
// using ValvulaGames.Domain.Entity.Account;
// using ValvulaGames.Domain.Entity.Game;
// using ValvulaGames.Domain.Entity.Library;


// using (var context = new BancoContext())
// {

//     // // Adiciona um account no banco
//     // var conta = new Account("joao", "123", "joao@email", "sobanski");
//     // context.Accounts.Add(conta);
//     // context.SaveChanges();

//     // // // cria jogo
//     // var game = new Game("MEGAMEN", 50);
//     // context.Games.Add(game);
//     // context.SaveChanges();

//     // var r = context.Accounts.Include(conta => conta.Libraries).First();

//     // r.IncreaseBalance(100);


//     // // adiciona jogo na bibioteca insere normal
//     // var compraGame = new Library(1, 1);
//     // context.Libraries.Add(compraGame);
//     // context.SaveChanges();

//     // var compraGame = new Library(1, 3);
//     // r.Libraries.Add(compraGame);
//     // context.Libraries.Add(compraGame);
//     // context.SaveChanges();


//     var r = context.Accounts
//         .Include(conta => conta.Libraries)
//         .Include(conta => conta.Transactions)
//         .First();

//     // Console.WriteLine(r.Slug);
//     // Console.WriteLine(r.Email);
//     // Console.WriteLine(r.Balance);
//     Console.WriteLine(r.Libraries.Count);
//     Console.WriteLine(r.Transactions.Count);




//     /// carrego tudo que sera necessario para executar
//     /// 

//     // ownerId receiverId gameId
//     // var r = context.Accounts.Include(conta => conta.Libraries).First();
//     // var game = context.Games.First();


//     // var tx = new ValvulaGames.Domain.Entity.Transaction(r, game, 1, r);

//     // context.Transactions.Add(tx);

//     // context.SaveChanges();


// }
