# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the csproj and restore
COPY TakeawayTitans/src/TakeawayTitans.csproj ./TakeawayTitans/
WORKDIR /src/TakeawayTitans
RUN dotnet restore

# Copy the rest of the project and publish
COPY TakeawayTitans/src/. ./TakeawayTitans/
RUN dotnet publish -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# Bind to Render's dynamic port
ENV ASPNETCORE_URLS=http://+:$PORT

ENTRYPOINT ["dotnet", "TakeawayTitans.dll"]
