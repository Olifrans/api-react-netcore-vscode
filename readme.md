

Curso:
https://www.youtube.com/watch?v=2Ayfi7OJhBI

Posição: 12:26


# Projeto  React App com .NET7 API-Backend usando VSCode (Entity Framework Core & SQL-Server)

Curso video: https://www.youtube.com/watch?v=2Ayfi7OJhBI
posição: 04:51

## Comando para criar o projeto

dotnet new react -o api-react-netcore-vscode --auth Individual

dotnet new react -o netcore-api-react-vscode --auth Individual


## Comando para criar arquivo readme.md
echo> readme.md

## Na pasta C:\WorkSpace\api-react-netcore-vscode\ClientApp>
Foi intalado o npm e o yarn !!!!

## cd .. para voltar a pasta C:\WorkSpace\api-react-netcore-vscode> e executar o projeto

dotnet tool install --global dotnet-ef
dotnet tool install --global dotnet-aspnet-codegenerator

dotnet build
dotnet run




Instalar o Entity Framework Core:

    dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    dotnet add package Microsoft.EntityFrameworkCore.Design
    dotnet add package Microsoft.EntityFrameworkCore.Tools
    dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

    dotnet add package Microsoft.AspNetCore.ApiAuthorization.IdentityServer
    dotnet add package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore
    dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
    dotnet add package Microsoft.AspNetCore.Identity.UI
    dotnet add package Microsoft.AspNetCore.SpaProxy
    dotnet add package Microsoft.EntityFrameworkCore.Relational
    dotnet add package Microsoft.EntityFrameworkCore.Sqlite

    dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
    dotnet add package Microsoft.AspNetCore.Identity.UI
    dotnet add package Azure.Identity







    Version="7.0.0-rc.1.22426.7"


Para habilitar os logs de rastreamento, defina a codegen_tracevariável de ambiente antes de executar dotnet-aspnet-codegenerator:

Prompt de comando:
SET codegen_trace=1

PowerShell:
$env:codegen_trace=1

Bash/Zsh/Peixe:
export codegen_trace=1

dotnet-aspnet-codegenerator


# Gerando controller pelo codegenerator
dotnet-aspnet-codegenerator controller -name NotesController -async -api -m Note -dc ContextDbReactNetCore --relativeFolderPath Controllers