#Step 1 建立可以還原和發行Dotnet Core專案的Image
FROM dotnet-core-base-image:latest as publishImage
# 建立app資料夾
RUN mkdir /app
# 設定app資料夾為WORKDIR
WORKDIR /app 
# 複製整個dotnet core mvc專案至publishImage
COPY ./DockerMVC/. .
# 還原專案套件
RUN dotnet restore
# 發行專案，並將發行網站用的檔案移至publish資料夾
RUN  dotnet publish  -c Release -o ./publish

#Step 2 建立可以執行dotnet core mvc 網站的Image
FROM dotnet-core-base-image:latest as execImage
# 複製publishImage的 publish 檔案到execImage
COPY --from=publishImage /app/publish/. .
# 開啟Container對外的5000 port
EXPOSE 5000
# 執行dotnet core mvc website 
ENTRYPOINT ["dotnet", "DockerMVC.dll", "--server.urls", "http://*:5000"]
