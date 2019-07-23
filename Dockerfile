FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY WorkshopNTL/*.csproj ./WorkshopNTL/
COPY Testing/*.csproj ./Testing/
RUN dotnet restore

# copy everything else and build app
COPY WorkshopNTL/. ./WorkshopNTL/
WORKDIR /app/WorkshopNTL
RUN dotnet publish -c Release -o out


FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS runtime
WORKDIR /app
COPY --from=build /app/WorkshopNTL/out ./
ENTRYPOINT ["dotnet", "WorkshopNTL.dll"]