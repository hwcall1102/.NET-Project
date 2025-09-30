FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy project file & restore
COPY src/TakeawayTitans/TakeawayTitans.csproj ./TakeawayTitans/
WORKDIR /TakeawayTitans
RUN dotnet restore

# Copy everything else & build
COPY src/TakeawayTitans/ .
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:$PORT
ENTRYPOINT ["dotnet", "TakeawayTitans.dll"]
