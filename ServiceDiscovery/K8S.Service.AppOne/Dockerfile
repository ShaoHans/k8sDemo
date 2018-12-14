# �����������⣬��Dockerfile�ļ���ͨ��restore��build��ʱ������nuget�������쳣�������޷�publish��
# �����ڱ����ֶ�dotnet publish��Ȼ��Ѵ�Dockerfile�ļ��ֶ�������publishĿ¼�£��������
# ��docker build -t k8s-service-appone .����������ɹ�
#FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
#WORKDIR /app
#EXPOSE 80
#COPY . .
#ENTRYPOINT ["dotnet", "K8S.Service.AppOne.dll"]

FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["ServiceDiscovery/K8S.Service.AppOne/K8S.Service.AppOne.csproj", "ServiceDiscovery/K8S.Service.AppOne/"]
RUN dotnet restore "ServiceDiscovery/K8S.Service.AppOne/K8S.Service.AppOne.csproj"
COPY . .
WORKDIR "/src/ServiceDiscovery/K8S.Service.AppOne"
RUN dotnet build "K8S.Service.AppOne.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "K8S.Service.AppOne.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "K8S.Service.AppOne.dll"]