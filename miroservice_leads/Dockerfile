FROM microsoft/aspnetcore:2.1 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.1 AS build
WORKDIR /src
COPY miroservice_leads.sln ./
COPY miroservice_leads/miroservice_leads.csproj miroservice_leads/
RUN dotnet restore -nowarn:msb3202,nu1503
COPY . .
WORKDIR /src/miroservice_leads
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "miroservice_leads.dll"]
