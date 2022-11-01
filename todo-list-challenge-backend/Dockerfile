#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["todo-list-challenge-backend/todo-list-challenge-backend.csproj", "todo-list-challenge-backend/"]
RUN dotnet restore "todo-list-challenge-backend/todo-list-challenge-backend.csproj"
COPY . .
WORKDIR "/src/todo-list-challenge-backend"
RUN dotnet build "todo-list-challenge-backend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "todo-list-challenge-backend.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "todo-list-challenge-backend.dll"]