#Get base SDK image from Microsoft
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

#Copy .csproj files and restores the dependencies and tools of a project. (via Nuget)
COPY *.sln ./
COPY ["LessonMonitor.AbstractCore/LessonMonitor.AbstractCore.csproj", "LessonMonitor.AbstractCore/"]
COPY ["LessonMonitor.BusinessLogic/LessonMonitor.BusinessLogic.csproj", "LessonMonitor.BusinessLogic/"]
COPY ["LessonMonitor.DAL/LessonMonitor.DAL.csproj", "LessonMonitor.DAL/"]
COPY ["LessonMonitor.WebAPI/LessonMonitor.WebAPI.csproj", "LessonMonitor.WebAPI/"]
RUN dotnet restore

#Copy everything else and build
COPY LessonMonitor.AbstractCore/. LessonMonitor.AbstractCore/
COPY LessonMonitor.BusinessLogic/. LessonMonitor.BusinessLogic/
COPY LessonMonitor.DAL/. LessonMonitor.DAL/
COPY LessonMonitor.WebAPI/. LessonMonitor.WebAPI/
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
EXPOSE 80
COPY --from=build-env /app/LessonMonitor.WebAPI/out .
ENTRYPOINT [ "dotnet", "LessonMonitor.WebAPI.dll" ]