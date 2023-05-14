#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Image base
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

#Copy necessary files
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["GestaoDeProdutos.Api/GestaoDeProdutos.Api.csproj", "GestaoDeProdutos.Api/"]
RUN dotnet restore "GestaoDeProdutos.Api/GestaoDeProdutos.Api.csproj"

#Copy all code
COPY . .
WORKDIR "/src/GestaoDeProdutos.Api"
RUN dotnet build "GestaoDeProdutos.Api.csproj" -c Release -o /app/build

#Publish application
FROM build AS publish
RUN dotnet publish "GestaoDeProdutos.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

#Final image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GestaoDeProdutos.Api.dll"]