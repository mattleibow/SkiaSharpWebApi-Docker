FROM microsoft/aspnetcore:2.0 AS base
RUN apt-get update; apt-get install libfontconfig1 -y

WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src

COPY SkiaSharpWebApi/SkiaSharpWebApi.csproj SkiaSharpWebApi/
RUN dotnet restore SkiaSharpWebApi/SkiaSharpWebApi.csproj
COPY . .
WORKDIR /src/SkiaSharpWebApi
RUN dotnet build SkiaSharpWebApi.csproj -c Release -o /bld

FROM build AS publish
RUN dotnet publish SkiaSharpWebApi.csproj -c Release -o /bld

FROM base AS final
WORKDIR /app
COPY --from=publish /bld .
ENTRYPOINT ["dotnet","SkiaSharpWebApi.dll"]
