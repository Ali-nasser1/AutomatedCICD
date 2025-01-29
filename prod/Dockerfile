FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# نسخ الملفات مع الحفاظ على الهيكل الداخلي
COPY ./src/DockerApi/DockerApi ./DockerApi/

# استعادة الحزم وبناء المشروع
RUN dotnet restore "DockerApi/DockerApi.csproj"
RUN dotnet build "DockerApi/DockerApi.csproj" -c Release -o /app/build

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/build .
EXPOSE 80
ENTRYPOINT ["dotnet", "DockerApi.dll"]