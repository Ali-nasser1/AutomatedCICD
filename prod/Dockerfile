FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ./src/DockerApi/DockerApi ./DockerApi

RUN dotnet restore "DockerApi/DockerApi.csproj"
RUN dotnet publish "DockerApi/DockerApi.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 80
ENTRYPOINT ["dotnet", "DockerApi.dll"]