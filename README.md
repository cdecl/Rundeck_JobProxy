
# Rundeck_JobProxy
- Gitlab Web Hook (POST Method) 대응 API 프록시 서버
- Rundeck 서버와 같은 머신에서 운영 

### 개발환경  
- .netcore sdk 2.1 

```bash
sudo rpm -Uvh https://packages.microsoft.com/config/rhel/7/packages-microsoft-prod.rpm

sudo yum update
sudo yum install dotnet-sdk-2.1
```

###  빌드 

```bash
git clone https://github.com/cdecl/Rundeck_JobProxy.git
cd Rundeck_JobProxy

dotnet restore 
dotnet build -c Release -o Deploy
sudo cp -r Deploy/* /var/aspnetcore/rundeck_jobproxy

```

### systemd 등록 
- [rundeck_jobproxy.service](systemd/rundeck_jobproxy.service)

