# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:9.0-preview AS build
WORKDIR /src
COPY . .
RUN dotnet publish -c Release -o /app

# Runtime Stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0-preview
WORKDIR /app
COPY --from=build /app ./

# ✅ Tell Render what port we are going to bind to
ENV PORT=10000

EXPOSE 10000

ENTRYPOINT ["dotnet", "portfolio_dotnet.dll"]