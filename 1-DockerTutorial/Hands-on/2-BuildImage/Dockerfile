#下載ubuntu Image
FROM ubuntu:18.04 as baseImage
# 安裝dotnet core sdk 
RUN apt-get update 
RUN apt-get install wget -y && apt-get install gpg -y
RUN wget -qO- https://packages.microsoft.com/keys/microsoft.asc | gpg --dearmor > microsoft.asc.gpg
RUN  mv microsoft.asc.gpg /etc/apt/trusted.gpg.d/
RUN wget -q https://packages.microsoft.com/config/ubuntu/18.04/prod.list 
RUN mv prod.list /etc/apt/sources.list.d/microsoft-prod.list
RUN chown root:root /etc/apt/trusted.gpg.d/microsoft.asc.gpg
RUN chown root:root /etc/apt/sources.list.d/microsoft-prod.list
RUN apt-get install apt-transport-https
RUN apt-get update
RUN apt-get install dotnet-sdk-2.1 -y
# 複製dotnet core mvc web site Publish Files到Image
COPY ./publish/. .
# 開啟Container對外的5000 port
EXPOSE 5000
# 執行dotnet core mvc website 
ENTRYPOINT ["dotnet", "DockerMVC.dll", "--server.urls", "http://*:5000"]
