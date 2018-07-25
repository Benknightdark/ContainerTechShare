FROM microsoft/dotnet:2.1.301-sdk-alpine as publishImage
RUN mkdir /app
WORKDIR /app 
COPY ./DockerMVC/. .
RUN dotnet restore
RUN  dotnet publish  -c Release -o ./publish

FROM microsoft/dotnet:2.1.2-runtime-bionic as execImage
COPY --from=publishImage /app/publish/. .
EXPOSE 5000
ENTRYPOINT ["dotnet", "DockerMVC.dll", "--server.urls", "http://*:5000"]

