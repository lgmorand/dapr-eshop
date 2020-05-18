#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["eshop.basket/eshop.basket.csproj", "eshop.basket/"]
RUN dotnet restore "eshop.basket/eshop.basket.csproj"
COPY . .
WORKDIR "/src/eshop.basket"
RUN dotnet build "eshop.basket.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "eshop.basket.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "eshop.basket.dll"]