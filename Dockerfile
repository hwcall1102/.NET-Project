# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy everything and restore
COPY . .
RUN dotnet restore

# Publish app
RUN dotnet publish -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# Render assigns $PORT dynamically
ENV ASPNETCORE_URLS=http://+:$PORT

# Expose the port (Render uses it automatically)
EXPOSE 8080

ENTRYPOINT ["dotnet", "TakeawayTitans.dll"]
