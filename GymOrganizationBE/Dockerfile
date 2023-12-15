FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["GymOrganization/GymOrganization.csproj", "GymOrganization/"]
COPY ["GymOrganization.Domain/GymOrganization.Domain.csproj", "GymOrganization.Domain/"]
COPY ["GymOrganization.Infrastructure/GymOrganization.Infrastructure.csproj", "GymOrganization.Infrastructure/"]
RUN dotnet restore "GymOrganization/GymOrganization.csproj"
COPY . .
WORKDIR "/src/GymOrganization"
RUN dotnet build "GymOrganization.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GymOrganization.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GymOrganization.dll"]
