FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY SkiaSharpWebApi/SkiaSharpWebApi.csproj SkiaSharpWebApi/
RUN dotnet restore SkiaSharpWebApi/SkiaSharpWebApi.csproj
COPY . .
WORKDIR /src/SkiaSharpWebApi
RUN dotnet build SkiaSharpWebApi.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish SkiaSharpWebApi.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SkiaSharpWebApi.dll"]
