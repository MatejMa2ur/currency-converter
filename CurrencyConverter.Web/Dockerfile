﻿FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["CurrencyConverter.Web.csproj", "./"]
RUN dotnet restore "CurrencyConverter.Web.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "CurrencyConverter.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
RUN dotnet publish "CurrencyConverter.Web.csproj" -c $BUILD_CONFIGURATION -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot .
COPY nginx.conf /etc/nginx/nginx.conf