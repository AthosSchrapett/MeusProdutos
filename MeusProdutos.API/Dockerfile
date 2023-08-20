#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["MeusProdutos.API/MeusProdutos.API.csproj", "MeusProdutos.API/"]
COPY ["MeusProdutos.Models/MeusProdutos.Models.csproj", "MeusProdutos.Models/"]
COPY ["MeusProdutos.Data/MeusProdutos.Data.csproj", "MeusProdutos.Data/"]
COPY ["MeusProdutos.Services/MeusProdutos.Services.csproj", "MeusProdutos.Services/"]
RUN dotnet restore "MeusProdutos.API/MeusProdutos.API.csproj"
COPY . .
WORKDIR "./MeusProdutos.API"
RUN dotnet build "MeusProdutos.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MeusProdutos.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MeusProdutos.API.dll"]