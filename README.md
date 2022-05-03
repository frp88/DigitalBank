# Digital Bank
Esta Solução foi desenvolvida para um sistema de um Banco Digital fictício. Implementada utilizando o Visual Studio Community 2022 e o framework .NET 5, os dados foram armazenados no banco de dados Sql Server por meio do ORM Entity Framework Core (“***code***-***first***”). Esta solução é composta por 6 (seis) projetos descritos a seguir:

## 1) Projeto “DigitalBank.Domain” 
Possui as Interfaces, Entidades e Enumerações utilizadas na Solução. Os arquivos desse projeto foram implementados baseados nos principais conceitos da programação orientada a objetos (POO). 

## 2) Projeto “DigitalBank.Infrastructure” 
Dividido em “Data”, módulo responsável por realizar a conexão com o Banco de Dados, persistência e recuperação dos dados. Este módulo contém o arquivo “DataContext” que estende de “DbContext” do ORM Entity Framework Core. 

O EntityFrameworkCore foi utilizado para realizar a persistência dos dados no Banco de Dados. ***OBS.:*** Foi utilizado a técnica “***code***-***first***”, em que primeiramente foi construído a solução e o Banco de Dados foi gerado a partir dos seguintes comandos:

```dotnet ef migrations add Initial -o Data/Migrations```

```dotnet ef database update```

Neste projeto foram instalados os seguintes pacotes do NuGet: “Microsoft.EntityFrameworkCore (5.0.9)”, “Microsoft.EntityFrameworkCore.Design (5.0.9)”, “Microsoft.EntityFrameworkCore.SqlServer (5.0.9)”, “Microsoft.EntityFrameworkCore.Tools (5.0.9)” e Newtonsoft.Json (13.0.1).

O outro módulo deste projeto é o “CrossCutting”, em que foi implementado um serviço que conecta com a API ViaCEP e uma classe para verificar se o CPF digitado é válido.

## 3) Projeto “DigitalBank.Application” 
Projeto criado utilizando o template “ASP.NET Core Web App” em que foram implementados os métodos disponibilizados pela Web API REST desenvolvida. Este projeto foi configurada a String de conexão com o banco de dados nos arquivos “appsettings.json” e “appsettings.Development.json”. 

No arquivo “Startup.cs” foi definido qual banco de dados foi utilizado (Sql Server), qual String de conexão foi usada e foi adicionado ao escopo do projeto os serviços e repositórios. 

Além disso, este projeto possui a pasta “Controllers. Nessa pasta foram criadas as classes que possuem as rotas da APIs que retornam “ActionResults”. A Web API desenvolvida foi testada no Swagger.

## 4) Projeto “DigitalBank.Service” 
Nesse foram implementadas as classes que interligam os demais projetos da solução e a maioria das regras de negócio. 

## 5) Projeto “DigitalBank.Domain.Test” 
Projeto criado utilizando o template “xUnit Test Project” em que foram implementados os testes unitários para as classes do projeto “DigitalBank.Domain”. 

## 6) Projeto “DigitalBank.Infrastructure.Test” 
Projeto criado utilizando o template “xUnit Test Project” em que foram implementados os testes unitários do projeto “DigitalBank.Infrastructure”. 

Neste projeto foi instalado pacote do NuGet “Microsoft.EntityFrameworkCore.Sqlite (5.0.9)”. Esse pacote do Sqlite permitiu a implementação da classe “DBInMemory.cs” e com isso foi possível testar as principais operações de persistência e recuperação de dados em um banco de dados em memória por meio do Sqlite. 

Para maiores detalhes ou caso tenha alguma dúvida entre em contato: *fernandorroberto@gmail.com* 👍
