FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 52327
EXPOSE 44338

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY AspnetCoreSearchTerm/AspnetCoreSearchTerm.csproj AspnetCoreSearchTerm/
RUN dotnet restore AspnetCoreSearchTerm/AspnetCoreSearchTerm.csproj
COPY . .
WORKDIR /src/AspnetCoreSearchTerm
RUN dotnet build AspnetCoreSearchTerm.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish AspnetCoreSearchTerm.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AspnetCoreSearchTerm.dll"]
