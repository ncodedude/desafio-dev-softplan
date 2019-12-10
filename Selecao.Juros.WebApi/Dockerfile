FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Selecao.Juros.WebApi/Selecao.Juros.WebApi.csproj", "Selecao.Juros.WebApi/"]
RUN dotnet restore "Selecao.Juros.WebApi/Selecao.Juros.WebApi.csproj"
COPY . .
WORKDIR "/src/Selecao.Juros.WebApi"
RUN dotnet build "Selecao.Juros.WebApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Selecao.Juros.WebApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Selecao.Juros.WebApi.dll"]