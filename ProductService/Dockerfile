#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["ProductService/ProductService.csproj", "ProductService/"]
COPY ["JeanStationModels/JeanStationModels.csproj", "JeanStationModels/"]
COPY ["Services/Services.csproj", "Services/"]
COPY ["DAL/DAL.csproj", "DAL/"]
RUN dotnet restore "ProductService/ProductService.csproj"
COPY . .
WORKDIR "/src/ProductService"
RUN dotnet build "ProductService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProductService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
# ENTRYPOINT ["dotnet", "ProductService.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet ProductService.dll

