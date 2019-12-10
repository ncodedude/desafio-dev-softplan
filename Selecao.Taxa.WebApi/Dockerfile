FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Selecao.Taxa.WebApi/Selecao.Taxa.WebApi.csproj", "Selecao.Taxa.WebApi/"]
RUN dotnet restore "Selecao.Taxa.WebApi/Selecao.Taxa.WebApi.csproj"
COPY . .
WORKDIR "/src/Selecao.Taxa.WebApi"
RUN dotnet build "Selecao.Taxa.WebApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Selecao.Taxa.WebApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Selecao.Taxa.WebApi.dll"]