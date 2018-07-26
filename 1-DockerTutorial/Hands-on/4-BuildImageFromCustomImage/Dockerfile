FROM microsoft/dotnet:2.1.302-sdk-alpine as publishImage
RUN mkdir /app
WORKDIR /app 
COPY ./DockerMVC/. .
RUN dotnet restore
RUN  dotnet publish  -c Release -o ./publish 

FROM microsoft/dotnet:2.1.2-aspnetcore-runtime as execImage
COPY --from=publishImage /app/publish/. .
ENTRYPOINT ["dotnet", "DockerMVC.dll"]