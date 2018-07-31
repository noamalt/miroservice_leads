FROM microsoft/dotnet:2.1-aspnetcore-runtime-alpine AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk-alpine AS build
WORKDIR /src
COPY miroservice_leads.sln ./
COPY miroservice_leads/miroservice_leads.csproj miroservice_leads/
RUN dotnet restore miroservice_leads/miroservice_leads.csproj
COPY . .
WORKDIR /src/miroservice_leads
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "miroservice_leads.dll"]
