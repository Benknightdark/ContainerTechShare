#載入Hands-on 1所作出來的image
FROM dotnet-core-base-image:latest as baseImage
# 複製dotnet core mvc web site Publish Files到Image
COPY ./publish/. .
# 開啟Container對外的5000 port
EXPOSE 5000
# 執行dotnet core mvc website 
ENTRYPOINT ["dotnet", "DockerMVC.dll", "--server.urls", "http://*:5000"]
