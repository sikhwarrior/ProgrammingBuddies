FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["src/ProgrammingBuddies.Api/ProgrammingBuddies.Api.csproj", "ProgrammingBuddies.Api/"]
COPY ["src/ProgrammingBuddies.Application/ProgrammingBuddies.Application.csproj", "ProgrammingBuddies.Application/"]
COPY ["src/ProgrammingBuddies.Domain/ProgrammingBuddies.Domain.csproj", "ProgrammingBuddies.Domain/"]
COPY ["src/ProgrammingBuddies.Contracts/ProgrammingBuddies.Contracts.csproj", "ProgrammingBuddies.Contracts/"]
COPY ["src/ProgrammingBuddies.Infrastructure/ProgrammingBuddies.Infrastructure.csproj", "ProgrammingBuddies.Infrastructure/"]
COPY ["Directory.Packages.props", "./"]
COPY ["Directory.Build.props", "./"]
RUN dotnet restore "ProgrammingBuddies.Api/ProgrammingBuddies.Api.csproj"
COPY . ../
WORKDIR /src/ProgrammingBuddies.Api
RUN dotnet build "ProgrammingBuddies.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish --no-restore -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
ENV ASPNETCORE_HTTP_PORTS=5001
EXPOSE 5001
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProgrammingBuddies.Api.dll"]