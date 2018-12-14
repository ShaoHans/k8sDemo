FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["ServiceDiscovery/K8S.Service.AppTwo/K8S.Service.AppTwo.csproj", "ServiceDiscovery/K8S.Service.AppTwo/"]
RUN dotnet restore "ServiceDiscovery/K8S.Service.AppTwo/K8S.Service.AppTwo.csproj"
COPY . .
WORKDIR "/src/ServiceDiscovery/K8S.Service.AppTwo"
RUN dotnet build "K8S.Service.AppTwo.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "K8S.Service.AppTwo.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "K8S.Service.AppTwo.dll"]