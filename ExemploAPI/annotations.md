Exemplo de API com .NET Core.

* Nuget Packages
	- Microsoft.EntityFrameworkCore.SqlServer
	- Microsoft.EntityFrameworkCore.InMemory

* Adicionando API Controller
	- Controllers > Add > New Scaffold item
	- API Controller with actions, using Entity Framework > Add
	- Model class: TodoItem (ExemploAPI.Models) > Data context class:TodoContext (ExemploAPI.Models) > Add

* Adicionando injeção de dependência
	- View > Other Windows > Package Maneger Console
	- PM> Add-Migration TodoList
	- PM> Update-Database

* Exemplo de teste Postman
	- POST: https://localhost:44302/api/TodoItems
	- Body > raw
	- { "name":"walk dog", "isComplete":true } > Send	


Referências:
https://docs.microsoft.com/pt-br/aspnet/core/tutorials/first-web-api?view=aspnetcore-3.1&tabs=visual-studio