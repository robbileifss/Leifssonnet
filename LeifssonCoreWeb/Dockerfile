FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["LeifssonCoreWeb/LeifssonCoreWeb.csproj", "LeifssonCoreWeb/"]
RUN dotnet restore "LeifssonCoreWeb/LeifssonCoreWeb.csproj"
COPY . .
WORKDIR "/src/LeifssonCoreWeb"
RUN dotnet build "LeifssonCoreWeb.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "LeifssonCoreWeb.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "LeifssonCoreWeb.dll"]