#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["eshop.catalog/eshop.catalog.csproj", "eshop.catalog/"]
RUN dotnet restore "eshop.catalog/eshop.catalog.csproj"
COPY . .
WORKDIR "/src/eshop.catalog"
RUN dotnet build "eshop.catalog.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "eshop.catalog.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "eshop.catalog.dll"]