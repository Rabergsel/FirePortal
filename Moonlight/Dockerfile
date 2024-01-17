#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["FirePortal/FirePortal.csproj", "FirePortal/"]
RUN dotnet restore "FirePortal/FirePortal.csproj"
COPY . .
WORKDIR "/src/FirePortal"
RUN dotnet build "FirePortal.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FirePortal.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
RUN mkdir -p /app/storage
RUN touch /app/storage/donttriggeranyerrors
RUN rm -r /app/storage/*
ENTRYPOINT ["dotnet", "FirePortal.dll"]