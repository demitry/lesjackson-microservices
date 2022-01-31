# dotnet --version

The installation was successful.

The following were installed at: ''
    • .NET SDK 5.0.404
    • .NET Runtime 5.0.13
    • ASP.NET Core Runtime 5.0.13
    • .NET Windows Desktop Runtime 5.0.13

This product collects usage data
    • More information and opt-out https://aka.ms/dotnet-cli-telemetry

Resources
    • .NET Documentation https://aka.ms/dotnet-docs
    • SDK Documentation https://aka.ms/dotnet-sdk-docs
    • Release Notes https://aka.ms/dotnet5-release-notes
    • Tutorials https://aka.ms/dotnet-tutorials


dotnet --version
5.0.404


# dotnet new webapi -n PlatformService

Welcome to .NET 5.0! 
---------------------
SDK Version: 5.0.404 

Telemetry
---------
The .NET tools collect usage data in order to help us improve your experience. It is collected by Microsoft and shared with the community. You can opt-out of telemetry by setting the DOTNET_CLI_TELEMETRY_OPTOUT environment variable to '1' or 'true' using your favorite shell.

Read more about .NET CLI Tools telemetry: https://aka.ms/dotnet-cli-telemetry

----------------
Installed an ASP.NET Core HTTPS development certificate.
To trust the certificate run 'dotnet dev-certs https --trust' (Windows and macOS only).
Learn about HTTPS: https://aka.ms/dotnet-https
----------------
Write your first app: https://aka.ms/dotnet-hello-world
Find out what's new: https://aka.ms/dotnet-whats-new
Explore documentation: https://aka.ms/dotnet-docs
Report issues and find source on GitHub: https://github.com/dotnet/core
Use 'dotnet --help' to see available commands or visit: https://aka.ms/dotnet-cli
--------------------------------------------------------------------------------------
Getting ready...
The template "ASP.NET Core Web API" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on PlatformService\PlatformService.csproj...
  Determining projects to restore...
  Restored D:\DATA\MYLEARNING\LesJackson\Microservices\PlatformService\PlatformService.csproj (in 2.78 sec).
Restore succeeded.

# code -r PlatformService

# dotnet new gitignore
d:\DATA\MYLEARNING\LesJackson\Microservices>dotnet new gitignore
The template "dotnet gitignore file" was created successfully.


dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection

dotnet add package Microsoft.EntityFrameworkCore --version 5.0.0

dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.0

dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 5.0.0

dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.0

# dotnet build

Microsoft (R) Build Engine version 16.11.2+f32259642 for .NET
Copyright (C) Microsoft Corporation. All rights reserved.

  Determining projects to restore...
  All projects are up-to-date for restore.
  PlatformService -> D:\src\LesJackson\lesjackson-microservices\PlatformService\bin\Debug\net5.0\PlatformService.dll

Build succeeded.
    0 Warning(s)
    0 Error(s)

Time Elapsed 00:00:03.48


# dotnet run

Building...

info: Microsoft.Hosting.Lifetime[0]
      Now listening on: https://localhost:5001
info: Microsoft.Hosting.Lifetime[0]
      Now listening on: http://localhost:5000
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
      Content root path: D:\src\LesJackson\lesjackson-microservices\PlatformService
info: Microsoft.Hosting.Lifetime[0]
      Application is shutting down...


# https://insomnia.rest/
Error: SSL peer certificate or SSH remote key was not OK
Settings -> General -> Request/Response -> uncheck "Validate Sertificate"

choco install curl

curl --request GET \
  --url http://localhost:5000/api/platforms

# git alias
cd ~
~/.gitconfig
add

[alias]
    lg = lg1
    lg1 = lg1-specific --all
    lg2 = lg2-specific --all
    lg3 = lg3-specific --all

    lg1-specific = log --graph --abbrev-commit --decorate --format=format:'%C(bold blue)%h%C(reset) - %C(bold green)(%ar)%C(reset) %C(white)%s%C(reset) %C(dim white)- %an%C(reset)%C(auto)%d%C(reset)'
    lg2-specific = log --graph --abbrev-commit --decorate --format=format:'%C(bold blue)%h%C(reset) - %C(bold cyan)%aD%C(reset) %C(bold green)(%ar)%C(reset)%C(auto)%d%C(reset)%n''          %C(white)%s%C(reset) %C(dim white)- %an%C(reset)'
    lg3-specific = log --graph --abbrev-commit --decorate --format=format:'%C(bold blue)%h%C(reset) - %C(bold cyan)%aD%C(reset) %C(bold green)(%ar)%C(reset) %C(bold cyan)(committed: %cD)%C(reset) %C(auto)%d%C(reset)%n''          %C(white)%s%C(reset)%n''          %C(dim white)- %an <%ae> %C(reset) %C(dim white)(committer: %cn <%ce>)%C(reset)'

# Docker
Package and Deploy
Dockerfile -> Docker Engine -> Docker Image
Push image to Docker Hub

# docker --version

Docker version 20.10.8, build 3967b7d

https://dotnetplaybook.com/
Cheat Sheets


# docker build -t dpoluektov/platformservice .

[+] Building 69.6s (7/14)
 => => sha256:ca2e100d2c30490f7cb34ab737bc33e9bd7e533446f6c3356c082caccae7be1a 2.17kB / 2.17kB                          0.0s 
 => => sha256:6552179c3509e3c4314b4065e0d2790563d01cd474e2fdd58be4d46acd48af6a 27.15MB / 27.15MB                       27.3s 
 => => sha256:0d6abc3048f0c2d58f135ff64df2e446d1020a8cb6a8f022abdb3dcf592be7b9 17.07MB / 17.07MB                       15.1s 
 => => sha256:5ee3cfc68efbb96e58657eb91f2969f6ba7ce2f8d099d711722eb9a7c480754e 31.77MB / 31.77MB                       21.4s 
 => => sha256:56c157384aef1ad8f078770b8efb754e9fe3fd2b0eceb215e0c14f753f286a66 156B / 156B                             15.3s 
 => => sha256:b5cdec11a1c3039c828687eceeafdb42b9732a9f205ea147dde498110c698d2c 8.65MB / 8.65MB                         24.4s 
 => => extracting sha256:6552179c3509e3c4314b4065e0d2790563d01cd474e2fdd58be4d46acd48af6a                               2.0s 
 => => extracting sha256:0d6abc3048f0c2d58f135ff64df2e446d1020a8cb6a8f022abdb3dcf592be7b9                               0.8s 
[+] Building 69.7s (7/14)
 => => sha256:ca2e100d2c30490f7cb34ab737bc33e9bd7e533446f6c3356c082caccae7be1a 2.17kB / 2.17kB                          0.0s 
 => => sha256:6552179c3509e3c4314b4065e0d2790563d01cd474e2fdd58be4d46acd48af6a 27.15MB / 27.15MB                       27.3s 
 => => sha256:0d6abc3048f0c2d58f135ff64df2e446d1020a8cb6a8f022abdb3dcf592be7b9 17.07MB / 17.07MB                       15.1s 
 => => sha256:5ee3cfc68efbb96e58657eb91f2969f6ba7ce2f8d099d711722eb9a7c480754e 31.77MB / 31.77MB                       21.4s 
 => => sha256:56c157384aef1ad8f078770b8efb754e9fe3fd2b0eceb215e0c14f753f286a66 156B / 156B                             15.3s 
 => => sha256:b5cdec11a1c3039c828687eceeafdb42b9732a9f205ea147dde498110c698d2c 8.65MB / 8.65MB                         24.4s 
 => => extracting sha256:6552179c3509e3c4314b4065e0d2790563d01cd474e2fdd58be4d46acd48af6a                               2.0s 
 => => extracting sha256:0d6abc3048f0c2d58f135ff64df2e446d1020a8cb6a8f022abdb3dcf592be7b9                               0.8s 
[+] Building 69.8s (7/14)
 => => extracting sha256:56c157384aef1ad8f078770b8efb754e9fe3fd2b0eceb215e0c14f753f286a66                               0.0s 
 => => extracting sha256:b5cdec11a1c3039c828687eceeafdb42b9732a9f205ea147dde498110c698d2c                               0.4s 
 => [build-env 1/6] FROM mcr.microsoft.com/dotnet/sdk:5.0@sha256:3ca1a372ff025d1f84bb2bef7dbb7c284ea3b49e00bcd0047336  67.7s 
 => => resolve mcr.microsoft.com/dotnet/sdk:5.0@sha256:3ca1a372ff025d1f84bb2bef7dbb7c284ea3b49e00bcd0047336b9bca9f8dfb  0.0s 
 => => sha256:3ca1a372ff025d1f84bb2bef7dbb7c284ea3b49e00bcd0047336b9bca9f8dfb7 2.17kB / 2.17kB                          0.0s 
 => => sha256:75ff3ad3a567482d7403eeeef5424fac254c5931a57992e07c2513204168c1a4 2.01kB / 2.01kB                          0.0s 
 => => sha256:e70f11cab56689a1067afe87cdd86e939f5459cdb4e685be4f8e1f4fc3a91687 7.11kB / 7.11kB                          0.0s 
 => => sha256:6552179c3509e3c4314b4065e0d2790563d01cd474e2fdd58be4d46acd48af6a 27.15MB / 27.15MB                       27.2s 
[+] Building 129.6s (15/15) FINISHED
 => [internal] load build definition from Dockerfile                                                                    0.0s 
 => => transferring dockerfile: 336B                                                                                    0.0s 
 => [internal] load .dockerignore                                                                                       0.0s 
 => => transferring context: 2B                                                                                         0.0s 
 => [internal] load metadata for mcr.microsoft.com/dotnet/aspnet:5.0                                                    2.0s 
 => [internal] load metadata for mcr.microsoft.com/dotnet/sdk:5.0                                                       1.9s 
 => [internal] load build context                                                                                       1.6s 
 => => transferring context: 20.78MB                                                                                    1.6s 
 => [stage-1 1/3] FROM mcr.microsoft.com/dotnet/aspnet:5.0@sha256:ca2e100d2c30490f7cb34ab737bc33e9bd7e533446f6c3356c0  32.9s 
 => => resolve mcr.microsoft.com/dotnet/aspnet:5.0@sha256:ca2e100d2c30490f7cb34ab737bc33e9bd7e533446f6c3356c082caccae7  0.0s 
 => => sha256:8906b71923faf4e187741d45edf43c56ba19321f911fb914f745cc056c1c75f4 1.37kB / 1.37kB                          0.0s 
 => => sha256:3aaf45867ca644caef3ac6735335506c4c260c5e82c4c355e04f5864730c12e6 3.27kB / 3.27kB                          0.0s 
 => => sha256:ca2e100d2c30490f7cb34ab737bc33e9bd7e533446f6c3356c082caccae7be1a 2.17kB / 2.17kB                          0.0s 
 => => sha256:6552179c3509e3c4314b4065e0d2790563d01cd474e2fdd58be4d46acd48af6a 27.15MB / 27.15MB                       27.3s 
 => => sha256:0d6abc3048f0c2d58f135ff64df2e446d1020a8cb6a8f022abdb3dcf592be7b9 17.07MB / 17.07MB                       15.1s 
 => => sha256:5ee3cfc68efbb96e58657eb91f2969f6ba7ce2f8d099d711722eb9a7c480754e 31.77MB / 31.77MB                       21.4s 
 => => sha256:56c157384aef1ad8f078770b8efb754e9fe3fd2b0eceb215e0c14f753f286a66 156B / 156B                             15.3s 
 => => sha256:b5cdec11a1c3039c828687eceeafdb42b9732a9f205ea147dde498110c698d2c 8.65MB / 8.65MB                         24.4s 
 => => extracting sha256:6552179c3509e3c4314b4065e0d2790563d01cd474e2fdd58be4d46acd48af6a                               2.0s 
 => => extracting sha256:0d6abc3048f0c2d58f135ff64df2e446d1020a8cb6a8f022abdb3dcf592be7b9                               0.8s 
 => => extracting sha256:5ee3cfc68efbb96e58657eb91f2969f6ba7ce2f8d099d711722eb9a7c480754e                               1.5s 
 => => extracting sha256:56c157384aef1ad8f078770b8efb754e9fe3fd2b0eceb215e0c14f753f286a66                               0.0s 
 => => extracting sha256:b5cdec11a1c3039c828687eceeafdb42b9732a9f205ea147dde498110c698d2c                               0.4s 
 => [build-env 1/6] FROM mcr.microsoft.com/dotnet/sdk:5.0@sha256:3ca1a372ff025d1f84bb2bef7dbb7c284ea3b49e00bcd0047336  92.4s 
 => => resolve mcr.microsoft.com/dotnet/sdk:5.0@sha256:3ca1a372ff025d1f84bb2bef7dbb7c284ea3b49e00bcd0047336b9bca9f8dfb  0.0s 
 => => sha256:3ca1a372ff025d1f84bb2bef7dbb7c284ea3b49e00bcd0047336b9bca9f8dfb7 2.17kB / 2.17kB                          0.0s 
 => => sha256:75ff3ad3a567482d7403eeeef5424fac254c5931a57992e07c2513204168c1a4 2.01kB / 2.01kB                          0.0s 
 => => sha256:e70f11cab56689a1067afe87cdd86e939f5459cdb4e685be4f8e1f4fc3a91687 7.11kB / 7.11kB                          0.0s 
 => => sha256:6552179c3509e3c4314b4065e0d2790563d01cd474e2fdd58be4d46acd48af6a 27.15MB / 27.15MB                       27.2s 
 => => sha256:5ee3cfc68efbb96e58657eb91f2969f6ba7ce2f8d099d711722eb9a7c480754e 31.77MB / 31.77MB                       21.4s 
 => => sha256:0d6abc3048f0c2d58f135ff64df2e446d1020a8cb6a8f022abdb3dcf592be7b9 17.07MB / 17.07MB                       15.1s 
 => => sha256:56c157384aef1ad8f078770b8efb754e9fe3fd2b0eceb215e0c14f753f286a66 156B / 156B                             15.3s 
 => => sha256:b5cdec11a1c3039c828687eceeafdb42b9732a9f205ea147dde498110c698d2c 8.65MB / 8.65MB                         24.4s 
 => => sha256:b2bd1b9bce4fe8e98abd1eeaee5434e485160be60eaa9c0cff77cddaefd7e5f0 27.56MB / 27.56MB                       39.2s 
 => => sha256:c2ff04abc29ceae5157967794c0f78796e17affc4aadc636c8de883fa57f76ea 105.57MB / 105.57MB                     85.1s 
 => => sha256:abeb2bf5ca3eda9c027a91f82e537b9503be2303b197eecb90ed1ba4fc383e99 12.69MB / 12.69MB                       39.1s 
 => => extracting sha256:6552179c3509e3c4314b4065e0d2790563d01cd474e2fdd58be4d46acd48af6a                             100.1s 
 => => extracting sha256:0d6abc3048f0c2d58f135ff64df2e446d1020a8cb6a8f022abdb3dcf592be7b9                              97.9s 
 => => extracting sha256:5ee3cfc68efbb96e58657eb91f2969f6ba7ce2f8d099d711722eb9a7c480754e                               1.5s 
 => => extracting sha256:56c157384aef1ad8f078770b8efb754e9fe3fd2b0eceb215e0c14f753f286a66                              95.4s 
 => => extracting sha256:b2bd1b9bce4fe8e98abd1eeaee5434e485160be60eaa9c0cff77cddaefd7e5f0                               1.4s 
 => => extracting sha256:c2ff04abc29ceae5157967794c0f78796e17affc4aadc636c8de883fa57f76ea                               4.7s 
 => => extracting sha256:abeb2bf5ca3eda9c027a91f82e537b9503be2303b197eecb90ed1ba4fc383e99                               0.6s 
 => [stage-1 2/3] WORKDIR /app                                                                                          2.3s 
 => [build-env 2/6] WORKDIR /app                                                                                        1.0s 
 => [build-env 3/6] COPY *.csproj ./                                                                                    0.1s 
 => [build-env 4/6] RUN dotnet restore                                                                                 28.5s 
 => [build-env 5/6] COPY . ./                                                                                           0.2s 
 => [build-env 6/6] RUN dotnet publish -c Release -o out                                                                4.9s 
 => [stage-1 3/3] COPY --from=build-env /app/out .                                                                      0.2s 
 => exporting to image                                                                                                  0.2s 
 => => exporting layers                                                                                                 0.2s 
 => => writing image sha256:a353df9828ababb4700654bd6e7c6636cf2f22e36802281143785a873bf9ffb6                            0.0s 
 => => naming to docker.io/dpoluektov/platformservice                                                                   0.0s 

Use 'docker scan' to run Snyk tests against images to find vulnerabilities and learn how to fix them

# docker run -p 8080:80 -d dpoluektov/platformservice

b766a603c0fdcaca933403dcd994726a00aaa8bb95026b3926757e0a757aff96

# docker ps

CONTAINER ID   IMAGE                        COMMAND                  CREATED              STATUS              PORTS                  NAMES    
       NAMES                                                                                                                   tcp   wonderful
b766a603c0fd   dpoluektov/platformservice   "dotnet PlatformServ…"   About a minute ago   Up About a minute   0.0.0.0:8080->80//tcp   wonderful_chaplygin

# docker stop b766a603c0fd

b766a603c0fd
# docker ps

CONTAINER ID   IMAGE     COMMAND   CREATED   STATUS    PORTS     NAMES

# run different container
PS D:\src\LesJackson\lesjackson-microservices\PlatformService> docker run -p 8080:80 -d dpoluektov/platformservice

36250effbb8032ec5617de69a91a1a039cc80e96f8afd042933e2cd3e230ec8b
PS D:\src\LesJackson\lesjackson-microservices\PlatformService> docker ps

CONTAINER ID   IMAGE                        COMMAND                  CREATED         STATUS         PORTS                  NAMES
36250effbb80   dpoluektov/platformservice   "dotnet PlatformServ…"   5 seconds ago   Up 3 seconds   0.0.0.0:8080->80/tcp   pedantic_knuth
PS D:\src\LesJackson\lesjackson-microservices\PlatformService> 

PS D:\src\LesJackson\lesjackson-microservices\PlatformService> docker stop 36250effbb80

36250effbb80
PS D:\src\LesJackson\lesjackson-microservices\PlatformService> docker ps

CONTAINER ID   IMAGE     COMMAND   CREATED   STATUS    PORTS     NAMES
# Run previous one 
docker start b766a603c0fd

FROM mcr.microsoft.com/dotnet/aspnet:5.0


# docker push dpoluektov/platformservice

Using default tag: latest
The push refers to repository [docker.io/dpoluektov/platformservice]
2dfab6a4d13e: Pushed
d5f5ebe55499: Pushed
41ca5b4feaf4: Pushed
4c1e7b065141: Pushed
5b1283bfec8a: Pushed
de5bcf849824: Pushed
f18b02b14138: Pushed
latest: digest: sha256:8016808f6a4a4b18d726c9575362f8d8dfa5d0298fb72b956a43dd2abc8ac7c3 size: 1789

# Kubernetes
kubectl version

Client Version: version.Info{Major:"1", Minor:"22", GitVersion:"v1.22.5", GitCommit:"5c99e2ac2ff9a3c549d9ca665e7bc05a3e18f07e", GitTreeState:"clean", BuildDate:"2021-12-16T08:38:33Z", GoVersion:"go1.16.12", Compiler:"gc", Platform:"windows/amd64"}
Server Version: version.Info{Major:"1", Minor:"22", GitVersion:"v1.22.5", GitCommit:"5c99e2ac2ff9a3c549d9ca665e7bc05a3e18f07e", GitTreeState:"clean", BuildDate:"2021-12-16T08:32:32Z", GoVersion:"go1.16.12", Compiler:"gc", Platform:"linux/amd64"}

# kubectl apply -f platforms-depl.yaml  
deployment.apps/platforms-depl created

# kubectl get deployments
NAME             READY   UP-TO-DATE   AVAILABLE   AGE 
platforms-depl   1/1     1            1           2m3s

# kubectl get pods
NAME                              READY   STATUS    RESTARTS   AGE  
platforms-depl-74c484b8cf-m7qbq   1/1     Running   0          3m31s


spec:
  replicas: 1
=> контейнер постоянно поднимается кубом при остановке и удалении

# kubectl delete deployment platforms-depl
deployment.apps "platforms-depl" deleted

# kubectl get deployments
No resources found in default namespace.

spec:
  replicas: 3

# kubectl apply -f platforms-depl.yaml    
deployment.apps/platforms-depl created
# kubectl get pods
NAME                              READY   STATUS    RESTARTS   AGE
platforms-depl-74c484b8cf-6vmrx   1/1     Running   0          14s
platforms-depl-74c484b8cf-klk24   1/1     Running   0          14s
platforms-depl-74c484b8cf-zv8m5   1/1     Running   0          14s

# Nodes - get access
Node port - external access to our pod

# kubectl apply -f platforms-np-srv.yaml
service/platformservice-srv created

# kubectl get services
NAME                  TYPE        CLUSTER-IP      EXTERNAL-IP   PORT(S)        AGE
kubernetes            ClusterIP   10.96.0.1       <none>        443/TCP        28h
platformservice-srv   NodePort    10.100.201.25   <none>        80:31449/TCP   2m11s

31449 port - we have to use to use service externally
 