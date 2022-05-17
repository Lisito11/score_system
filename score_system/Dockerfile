FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["score_system.csproj", "./"]
RUN dotnet restore "score_system.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "score_system.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "score_system.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet score_system.dll