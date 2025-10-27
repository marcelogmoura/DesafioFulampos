FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["Aplicacao/Desafio.API/Desafio.API.csproj", "Aplicacao/Desafio.API/"]
COPY ["Domain/Domain.csproj", "Domain/"]

RUN dotnet restore "Aplicacao/Desafio.API/Desafio.API.csproj"

COPY . .

WORKDIR /src/Aplicacao/Desafio.API
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final

ENTRYPOINT ["dotnet", "Desafio.API.dll"]