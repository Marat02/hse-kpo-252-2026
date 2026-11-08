FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["HSE.KPO.MVC/HSE.KPO.MVC.csproj", "HSE.KPO.MVC/"]
RUN dotnet restore "HSE.KPO.MVC/HSE.KPO.MVC.csproj"
COPY . .
WORKDIR "/src/HSE.KPO.MVC"
RUN dotnet build "./HSE.KPO.MVC.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./HSE.KPO.MVC.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HSE.KPO.MVC.dll"]
