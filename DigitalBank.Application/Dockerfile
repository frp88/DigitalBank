#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["DigitalBank.Application/DigitalBank.Application.csproj", "DigitalBank.Application/"]
COPY ["DigitalBank.Infra.Data/DigitalBank.Infra.Data.csproj", "DigitalBank.Infra.Data/"]
COPY ["DigitalBank.Domain/DigitalBank.Domain.csproj", "DigitalBank.Domain/"]
COPY ["DigitalBank.Service/DigitalBank.Service.csproj", "DigitalBank.Service/"]
COPY ["DigitalBank.Infra.CrossCutting/DigitalBank.Infra.CrossCutting.csproj", "DigitalBank.Infra.CrossCutting/"]
RUN dotnet restore "DigitalBank.Application/DigitalBank.Application.csproj"
COPY . .
WORKDIR "/src/DigitalBank.Application"
RUN dotnet build "DigitalBank.Application.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DigitalBank.Application.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DigitalBank.Application.dll"]