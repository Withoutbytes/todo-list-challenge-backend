#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["teste-web-api/teste-web-api.csproj", "teste-web-api/"]
RUN dotnet restore "teste-web-api/teste-web-api.csproj"
COPY . .
WORKDIR "/src/teste-web-api"
RUN dotnet build "teste-web-api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "teste-web-api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "teste-web-api.dll"]