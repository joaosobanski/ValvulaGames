

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