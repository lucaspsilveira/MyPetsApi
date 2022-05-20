FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MyPets/MyPets.csproj", "MyPets/"]
RUN dotnet restore "MyPets/MyPets.csproj"
COPY . .
WORKDIR "/src/MyPets"
RUN dotnet build "MyPets.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyPets.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyPets.dll"]
