# Docker安裝流程
1. 申請Docker hub帳號 (https://hub.docker.com/)
2. 進入Docker windows版本下載連結 (https://store.docker.com/editions/community/docker-ce-desktop-windows)
3. 點擊"Please login To Download"連結，並用DOCKER帳號登入

4.  登入完成後，會返回到下載Windows版本Docker的網頁，並滑至下方，會有兩種版本的Docker下載連結，請下載Edge Channel的版本
5. 下載完成後，點擊Docker的安裝檔
6. 完成安裝後，會在桌面看到Docker執行檔，請以【系統管理者身份】點擊執行
7. 執行後，在桌面右下角功能列會出現一直鯨魚在噴水，當牠噴完水，代表Docker已經執行成功
8. 右鍵點擊鯨魚，並點擊Sign in選項後，輸入自己的Docker hub帳密
9. (此步驟可作可不作) 右鍵點擊鯨魚，並點擊Settings選項後
10. (此步驟可作可不作) 點擊Advanced選項，可依自己的需求修改docker vm的位置
11. 開啟Command line 程式，輸入 docker -v 查詢目前本機的docker版本
12. 輸入docker login，並輸入自己的Docker hub帳密
13. 輸入docker run hell-world，建立一個測試用Container
14. 輸入docker ps -a，查詢在step 13所建立的Conatainer是否有執行成功
## issue solution
- https://github.com/docker/for-win/issues/1631#issuecomment-371256016