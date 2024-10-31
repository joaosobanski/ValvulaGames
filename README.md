

### Criar a solucao sln

dotnet new sln -n _nome_

# Criar o projeto Domain classlib

dotnet new classlib -n Domain

## Adicionar o projeto na sln

dotnew sln ..nome.. add Domain/Domain.csproj

## Validar se ta funcionando a sln
dotnet build
ira aparecer o domain

## Criar pasta Tests
mkdir Tests

## Criar projeto nunit

dotnet new nunit -n UnitTest

## Adicionar a solucao

dotnew sln ..nome.. add Tests/UnitTest/UnitTest.csproj

## Executar Teste

dotnet test

## Adicionar dependencias Guard FluentTest
# No projeto Teste
dotnet add package FluentAssertions

# no projeto Domain
dotnet add package Microsoft.Toolkit.Diagnostics

## Adiciona dependendecia.

dotnet add reference ../../Domain/Domain.csproj 

## Dependencia do Factory 
dotnet add package Faker.Net --version 2.0.163

dotnet add package bogus




## ..



dotnet add package Microsoft.Data.Sqlite
        var connectionString = "Data Source=meuBanco.db";
dotnet add package Microsoft.EntityFrameworkCore.Sqlite

dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Design

using Microsoft.EntityFrameworkCore;

public class MeuDbContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=meuBanco.db");
    }
}


infra
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
dotnet add package Microsoft.EntityFrameworkCore.Tools

api
FluentValidation
FluentValidation.DependencyInjectionExtensions
Microsoft.AspNetCore.Cors
Microsoft.AspNetCore.OpenApi
Swashbuckle.AspNetCore
System.IdentityModel.Tokens.Jwt
Microsoft.AspNetCore.Authentication.JwtBearer
MediatR
Npgsql.EntityFrameworkCore.PostgreSQL
Swashbuckle.AspNetCore

apli
FluentValidation
MediatR
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools



dotnet add package FluentValidation
dotnet add package MediatR

# Gerar

dotnet ef migrations add first --context BancoContext --project Infrastructure/Infrastructure.csproj 

# Aplicar

dotnet ef database update --context BancoContext --project Infrastructure/Infrastructure.csproj 
