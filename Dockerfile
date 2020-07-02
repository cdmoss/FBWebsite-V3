#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["MHFoodBank.Web/MHFoodBank.Web.csproj", "MHFoodBank.Web/"]
RUN dotnet restore "MHFoodBank.Web/MHFoodBank.Web.csproj"
COPY . .
WORKDIR "/src/MHFoodBank.Web"
RUN dotnet build "MHFoodBank.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MHFoodBank.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MHFoodBank.Web.dll"]