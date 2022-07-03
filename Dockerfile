#Get base SDK image from Microsoft
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

#Copy .csproj files and restores the dependencies and tools of a project. (via Nuget)
COPY *.csproj ./
RUN dotent restore

#Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
EXPOSE 80
COPY --from=build-env /app/out .
ENTRYPOINT [ "dotnet", "LessonMonitor.WebAPI.dll" ]