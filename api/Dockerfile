FROM mcr.microsoft.com/dotnet/sdk:8.0-noble as build

COPY WebApplication1/ /app/

WORKDIR /app

RUN dotnet publish -c Release -o published

FROM mcr.microsoft.com/dotnet/aspnet:8.0-noble as runtime

COPY --from=build /app/published/* /app/

WORKDIR /app

EXPOSE 8080

ENTRYPOINT [ "dotnet", "WebApplication1.dll", "--configuration Default Configuration" ]
