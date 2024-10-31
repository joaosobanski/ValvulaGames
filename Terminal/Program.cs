using Infrastructure;

using (var context = new BancoContext())
{
    var service = new Service(context);

    // Criar uma nova conta
    service.CreateAccount("joao", "123", "joao@email", "sobanski");

    // Adicionar saldo a uma conta
    service.AddBalance(1, 100);

    // Criar um novo jogo
    service.CreateGame("MEGAMAN", 50);

    // Listar todas as contas
    var accounts = service.GetAllAccounts();
    foreach (var acc in accounts)
    {
        Console.WriteLine($"{acc.Slug} - {acc.Email} - Saldo: {acc.Balance}");
    }

    // Adicionar um jogo à biblioteca de um usuário
    service.AddGameToLibrary(1, 1);

    // Criar uma transação
    service.CreateTransaction(1, 1, 1);
}
