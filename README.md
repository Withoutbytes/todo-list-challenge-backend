
# Desafio TODO LIST BACKEND

Desafio TODO LIST que consiste em uma página com uma uma lista que o usuário pode criar, ver, modificar tarefas e também pode marca-las como concluidas.
Tudo isso é refletido para todos os usuários que estão vendo a página, pois as tarefas são armazenadas em um banco de dados, e disponibilizadas por um backend.

## Dependencias
- Visual Studio
- ASP.NET
- .NET 6.0

## Instalação
- git clone github.com/withoutbytes/todo-list-challenge-backend.git
- Abra o projeto no visual studio
- Execute a opção de depuração com docker

## Configuração de ambiente
Para que o projeto funcione corretamente configure o arquivo

appsettings.Development.json
```json
{
	"MongoDB": {
		"ConnectionString": "mongodb+srv://:@mongodb.net/todolistchallange?retryWrites=true&w=majority",
		"Database": "todolistchallange"
	},
	"Logging": {
		"LogLevel": {
			"Default": "Information",
			"Microsoft.AspNetCore": "Warning"
		}
	}
}
```

## Projeto Front-end
https://github.com/Withoutbytes/todo-list-challenge

## Tecnologias
- C#
- ASP.Net
- Docker

