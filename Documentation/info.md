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

# dotnet new webapi -n CommandsService
The template "ASP.NET Core Web API" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on CommandsService\CommandsService.csproj...
  Determining projects to restore...
  Restored D:\src\LesJackson\lesjackson-microservices\CommandsService\CommandsService.csproj (in 230 ms).
Restore succeeded.


# Commands Service 
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
dotnet add package Microsoft.EntityFrameworkCore --version 5.0.0
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.0
dotnet add package Microsoft.EntityFrameworkCore.InMemory

dotnet new gitignore

# Two Services talking to each other synchrouniusly using HTTP
Synchronous HTTP Communication

Platform resource is dependent on Command Resource
So we have 2 controllers


### The SSL connection could not be established
#### The remote certificate is invalid because of errors in the certificate chain: UntrustedRoot

//TODO: got exception: "The SSL connection could not be established, see inner exception"
--> Could NOT send synchronously: The SSL connection could not be established, see inner exception.
Could NOT send synchronously: The SSL connection could not be established, see inner exception.: The remote certificate is invalid because of errors in the certificate chain: UntrustedRoot

The .NET gRPC client requires the service to have a trusted certificate.

If you are testing your app locally and the ASP.NET Core HTTPS development certificate is not trusted. For instructions to fix this issue, you should trust the develop certificate as this article shows.

If you are calling a gRPC service on another machine and are unable to trust the certificate then the gRPC client can be configured to ignore the invalid certificate. The following code uses HttpClientHandler.ServerCertificateCustomValidationCallback to allow calls without a trusted certificate:

 var httpHandler = new HttpClientHandler();
 // Return `true` to allow certificates that are untrusted/invalid
 httpHandler.ServerCertificateCustomValidationCallback = 
     HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
    
 var channel = GrpcChannel.ForAddress("https://localhost:5001",
     new GrpcChannelOptions { HttpHandler = httpHandler });
 var client = new Greet.GreeterClient(channel);


Notice: Untrusted certificates should only be used during app development. Production apps should always use valid certificates.
...
ServicePointManager.ServerCertificateValidationCallback += (o, c, ch, er) => true;
But this means that you will trust all certificates. For a service that isn't just run locally, something a bit smarter will be needed. In the first instance you could use this code to just test whether it solves your problem.


### Run PowerShell ps1
Got an 'unexpected token' error while running ps1 script?
This particular problem vanished after **changing the encoding of the PS1 file from UTF-8 to UTF-8-BOM.**

### Commands Service -> Kube

We created
Test Endpoint - Command Service
Syncronous Data Client in our Platform Service that call our Command Service syncronously.

So move Command Service into kubernetes
Create Cluster Ip to allow them talk to each-other

#### docker build -t dpoluektov/commandsservice .
[+] Building 14.1s (15/15) FINISHED
 => [internal] load build definition from Dockerfile                                                                  0.1s 
 => => transferring dockerfile: 336B                                                                                  0.0s 
 => [internal] load .dockerignore                                                                                     0.1s 
 => => transferring context: 2B                                                                                       0.0s 
 => [internal] load metadata for mcr.microsoft.com/dotnet/aspnet:5.0                                                  0.6s 
 => [internal] load metadata for mcr.microsoft.com/dotnet/sdk:5.0                                                     0.7s 
 => [build-env 1/6] FROM mcr.microsoft.com/dotnet/sdk:5.0@sha256:3ca1a372ff025d1f84bb2bef7dbb7c284ea3b49e00bcd004733  0.0s 
 => [stage-1 1/3] FROM mcr.microsoft.com/dotnet/aspnet:5.0@sha256:ca2e100d2c30490f7cb34ab737bc33e9bd7e533446f6c3356c  0.0s 
 => [internal] load build context                                                                                     0.2s 
 => => transferring context: 1.35MB                                                                                   0.1s 
 => CACHED [build-env 2/6] WORKDIR /app                                                                               0.0s 
 => [build-env 3/6] COPY *.csproj ./                                                                                  0.1s 
 => [build-env 4/6] RUN dotnet restore                                                                                7.9s 
 => [build-env 5/6] COPY . ./                                                                                         0.2s 
 => [build-env 6/6] RUN dotnet publish -c Release -o out                                                              4.6s 
 => CACHED [stage-1 2/3] WORKDIR /app                                                                                 0.0s 
 => [stage-1 3/3] COPY --from=build-env /app/out .                                                                    0.1s 
 => exporting to image                                                                                                0.1s 
 => => exporting layers                                                                                               0.1s 
 => => writing image sha256:bb3c75d86115eddb58a98ce45ab781e56671ab98a6f16b8bf41dd5b69c45ffb7                          0.0s 
 => => naming to docker.io/dpoluektov/commandsservice                                                                 0.0s 

Use 'docker scan' to run Snyk tests against images to find vulnerabilities and learn how to fix them

#### docker push dpoluektov/commandsservice
Using default tag: latest
The push refers to repository [docker.io/dpoluektov/commandsservice]
6994bb9ec23f: Pushed
d5f5ebe55499: Mounted from dpoluektov/platformservice
41ca5b4feaf4: Mounted from dpoluektov/platformservice
4c1e7b065141: Mounted from dpoluektov/platformservice
5b1283bfec8a: Mounted from dpoluektov/platformservice
de5bcf849824: Mounted from dpoluektov/platformservice
f18b02b14138: Mounted from dpoluektov/platformservice
latest: digest: sha256:e81d1f6a177f0a47e305a67610c3993c4bc2482b4ee3f8261961cb993a2f13ec size: 1789

Run Detached:
#### docker run -p 8080:80 -d dpoluektov/commandsservice
cda043da6fe0cd7a6ce393d3a3f765c8d8891e3c58d58a0c92af0c20220d81c0

Run Not Detached - with command line logging:
#### docker run -p 8080:80 dpoluektov/commandsservice   
info: Microsoft.Hosting.Lifetime[0]
      Now listening on: http://[::]:80
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Production
info: Microsoft.Hosting.Lifetime[0]
      Content root path: /app
info: Microsoft.Hosting.Lifetime[0]
      Application is shutting down...


### Adding an API Gateway

yaml

NB!

Make sure you separate the deployment from the Cluster IP config with: ---
---

Platform service deployment config was changed => 
re-package, re-build, re-deploy

cd .\PlatformService\

### docker build -t dpoluektov/platformservice .
[+] Building 7.2s (15/15) FINISHED
 => [internal] load build definition from Dockerfile                                                                              0.1s 
 => => transferring dockerfile: 336B                                                                                              0.0s 
 => [internal] load .dockerignore                                                                                                 0.1s 
 => => transferring context: 2B                                                                                                   0.0s 
 => [internal] load metadata for mcr.microsoft.com/dotnet/aspnet:5.0                                                              0.6s 
 => [internal] load metadata for mcr.microsoft.com/dotnet/sdk:5.0                                                                 0.6s 
 => [build-env 1/6] FROM mcr.microsoft.com/dotnet/sdk:5.0@sha256:3ca1a372ff025d1f84bb2bef7dbb7c284ea3b49e00bcd0047336b9bca9f8dfb  0.0s 
 => [stage-1 1/3] FROM mcr.microsoft.com/dotnet/aspnet:5.0@sha256:ca2e100d2c30490f7cb34ab737bc33e9bd7e533446f6c3356c082caccae7be  0.0s 
 => [internal] load build context                                                                                                 0.4s 
 => => transferring context: 13.28MB                                                                                              0.3s 
 => CACHED [build-env 2/6] WORKDIR /app                                                                                           0.0s 
 => CACHED [build-env 3/6] COPY *.csproj ./                                                                                       0.0s 
 => CACHED [build-env 4/6] RUN dotnet restore                                                                                     0.0s 
 => [build-env 5/6] COPY . ./                                                                                                     0.3s 
 => [build-env 6/6] RUN dotnet publish -c Release -o out                                                                          5.3s 
 => CACHED [stage-1 2/3] WORKDIR /app                                                                                             0.0s 
 => [stage-1 3/3] COPY --from=build-env /app/out .                                                                                0.2s 
 => exporting to image                                                                                                            0.2s 
 => => exporting layers                                                                                                           0.2s 
 => => writing image sha256:86b7bc1df7150bb4305779ade654387b4a782575414cac005b0af3036d08b995                                      0.0s 
 => => naming to docker.io/dpoluektov/platformservice                                                                             0.0s 

Use 'docker scan' to run Snyk tests against images to find vulnerabilities and learn how to fix them

### docker push dpoluektov/platformservice
Using default tag: latest
The push refers to repository [docker.io/dpoluektov/platformservice]
4e5a6e476fb6: Pushed
d5f5ebe55499: Layer already exists
41ca5b4feaf4: Layer already exists
4c1e7b065141: Layer already exists
5b1283bfec8a: Layer already exists
de5bcf849824: Layer already exists
f18b02b14138: Layer already exists
latest: digest: sha256:381645f586eb00cf1551573e54843c1ab82d25aa3797ae1ea334a278de5a46ba size: 1789

**kubectl get deployments**
NAME             READY   UP-TO-DATE   AVAILABLE   AGE
platforms-depl   1/1     1            1           6d15h

**kubectl get pods**
NAME                              READY   STATUS    RESTARTS   AGE
platforms-depl-74c484b8cf-np4rw   1/1     Running   0          6d15h

**kubectl get services**
NAME                  TYPE        CLUSTER-IP      EXTERNAL-IP   PORT(S)        AGE
kubernetes            ClusterIP   10.96.0.1       <none>        443/TCP        7d9h
platformservice-srv   NodePort    10.100.201.25   <none>        80:31449/TCP   6d4h

Apply platforms deployment again

**kubectl apply -f platforms-depl.yaml**
deployment.apps/platforms-depl **unchanged**
service/platforms-clusterip-srv **created**

### Force kubernetes to refresh the image

#### kubectl get deployments                                                             
NAME             READY   UP-TO-DATE   AVAILABLE   AGE  
platforms-depl   1/1     1            1           6d15h
#### kubectl rollout restart deployment platforms-depl
deployment.apps/platforms-depl restarted

**kubectl get pods**
NAME                              READY   STATUS    RESTARTS   AGE
platforms-depl-5b69dbc478-s7scc   1/1     Running   0          63s

See in docker console:
--> Command Service endpoint: http://commands-clusterip-srv:80/api/c/platforms/

--> Seeding Data... 

**kubectl get deployments**
NAME             READY   UP-TO-DATE   AVAILABLE   AGE
platforms-depl   1/1     1            1           6d15h


#### kubectl apply -f commands-depl.yaml  
deployment.apps/commands-depl created
service/commands-clusterip-srv created

#### kubectl get services
NAME                      TYPE        CLUSTER-IP       EXTERNAL-IP   PORT(S)        AGE
commands-clusterip-srv    ClusterIP   10.108.158.183   <none>        80/TCP         61s
kubernetes                ClusterIP   10.96.0.1        <none>        443/TCP        7d9h
platforms-clusterip-srv   ClusterIP   10.98.191.115    <none>        80/TCP         10m
platformservice-srv       NodePort    10.100.201.25    <none>        80:31449/TCP   6d4h


#### kubectl get deployments
NAME             READY   UP-TO-DATE   AVAILABLE   AGE
commands-depl    1/1     1            1           2m7s
platforms-depl   1/1     1            1           6d15h

#### kubectl get pods       
NAME                              READY   STATUS    RESTARTS   AGE
commands-depl-7b9447fbb8-kdvtb    1/1     Running   0          2m42s
platforms-depl-5b69dbc478-s7scc   1/1     Running   0          8m26s

Create Platform, Check Docker Logs:
Platform Service
--> Send POST to CommandService was OK!
Command Service
--> Inbound POST # Commands Service

Fantastic!

https://youtu.be/DgVjEo3OGBI?t=17072

4:44:55 Adding an API Gateway
Adding an API Gateway with Ingress nginx 
# Install Ingress nginx 

https://kubernetes.github.io/ingress-nginx/deploy/

Different providers
Check yaml file:
https://raw.githubusercontent.com/kubernetes/ingress-nginx/controller-v1.1.1/deploy/static/provider/aws/deploy.yaml

kubectl apply -f https://raw.githubusercontent.com/kubernetes/ingress-nginx/controller-v1.1.1/deploy/static/provider/aws/deploy.yaml

kubectl apply -f https://raw.githubusercontent.com/kubernetes/ingress-nginx/controller-v1.1.1/deploy/static/provider/aws/deploy.yaml
namespace/ingress-nginx created
serviceaccount/ingress-nginx created
configmap/ingress-nginx-controller created
clusterrole.rbac.authorization.k8s.io/ingress-nginx created
clusterrolebinding.rbac.authorization.k8s.io/ingress-nginx created
role.rbac.authorization.k8s.io/ingress-nginx created
rolebinding.rbac.authorization.k8s.io/ingress-nginx created
service/ingress-nginx-controller-admission created
service/ingress-nginx-controller created
deployment.apps/ingress-nginx-controller created
ingressclass.networking.k8s.io/nginx created
validatingwebhookconfiguration.admissionregistration.k8s.io/ingress-nginx-admission created
serviceaccount/ingress-nginx-admission created
clusterrole.rbac.authorization.k8s.io/ingress-nginx-admission created
clusterrolebinding.rbac.authorization.k8s.io/ingress-nginx-admission created
role.rbac.authorization.k8s.io/ingress-nginx-admission created
rolebinding.rbac.authorization.k8s.io/ingress-nginx-admission created
job.batch/ingress-nginx-admission-create created
job.batch/ingress-nginx-admission-patch created

kubectl get deployments 
NAME             READY   UP-TO-DATE   AVAILABLE   AGE  
commands-depl    1/1     1            1           3d23h
platforms-depl   1/1     1            1           10d  

kubectl get pods       
NAME                              READY   STATUS    RESTARTS      AGE  
commands-depl-7b9447fbb8-kdvtb    1/1     Running   1 (23h ago)   3d23h
platforms-depl-5b69dbc478-s7scc   1/1     Running   1 (23h ago)   3d23h

Q: ??? Empty
A: kube namespaces!

We are working in our project **default** namespace

## kubectl get namespace
NAME              STATUS   AGE
**default**           Active   11d
ingress-nginx     Active   3m22s
kube-node-lease   Active   11d
kube-public       Active   11d
kube-system       Active   11d

## kubectl get pods --namespace=ingress-nginx
NAME                                        READY   STATUS      RESTARTS   AGE
ingress-nginx-admission-create--1-sws7r     0/1     Completed   0          5m7s
ingress-nginx-admission-patch--1-55mmb      0/1     Completed   1          5m7s
ingress-nginx-controller-54d8b558d4-kv9v5   1/1     Running     0          5m7s

## kubectl get services --namespace=ingress-nginx
NAME                                 TYPE           CLUSTER-IP       EXTERNAL-IP   PORT(S)                      AGE
ingress-nginx-controller             LoadBalancer   10.108.135.173   localhost     80:30995/TCP,443:31393/TCP   8m9s        
ingress-nginx-controller-admission   ClusterIP      10.106.193.62    <none>        443/TCP                      8m10s   

## Create the config file to route our services

yaml

add to hosts
win ( C:\Windows\System32\drivers\etc )
127.0.0.1 acme.com 

kubectl apply -f ingress-srv.yaml  
ingress.networking.k8s.io/ingress-srv created

GET http://acme.com/api/platforms

Fantastic!

### Storage
 - 1) Persistent Volume Claim
 - 2) Persistent Volume
 - 3) Storage Class

kubectl get storageclass
NAME                 PROVISIONER          RECLAIMPOLICY   VOLUMEBINDINGMODE   ALLOWVOLUMEEXPANSION   AGE
hostpath (default)   docker.io/hostpath   Delete          Immediate           false                  11d


We have to create a Persistent Volume Claim
Will use persistent defaults, storage slass

local-pvc.yaml

pvc means Persistent Volume Claim

kubectl apply -f local-pvc.yaml 
persistentvolumeclaim/mssql-claim created

kubectl get pvc
NAME          STATUS   VOLUME                                     CAPACITY   ACCESS MODES   STORAGECLASS   AGE
mssql-claim   Bound    pvc-a3862333-b255-4d48-a955-0b49b6b02bdc   200Mi      RWX            hostpath       48s


get storageclass        
NAME                 PROVISIONER          RECLAIMPOLICY   VOLUMEBINDINGMODE   ALLOWVOLUMEEXPANSION   AGE
hostpath (default)   docker.io/hostpath   Delete          Immediate           false                  11d


SQL Server will require system admin password

Saving password in config - bad idea
create secret

kubectl create secret generic mssql --from-literal=SA_PASSWORD="Pa55w0rd!"
secret/mssql created

Create deployment for sql server

kubectl apply -f mssql-plat-depl.yaml
deployment.apps/mssql-depl created
service/mssql-clusterip-srv created
service/mssql-loadbalancer created

kubectl get services
NAME                      TYPE           CLUSTER-IP       EXTERNAL-IP   PORT(S)          AGE 
commands-clusterip-srv    ClusterIP      10.108.158.183   <none>        80/TCP           4d8h
kubernetes                ClusterIP      10.96.0.1        <none>        443/TCP          11d 
mssql-clusterip-srv       ClusterIP      10.104.32.199    <none>        1433/TCP         25s 
mssql-loadbalancer        LoadBalancer   10.111.112.111   localhost     1433:30457/TCP   25s
platforms-clusterip-srv   ClusterIP      10.98.191.115    <none>        80/TCP           4d8h
platformservice-srv       NodePort       10.100.201.25    <none>        80:31449/TCP     10d


kubectl get pods
NAME                              READY   STATUS              RESTARTS      AGE
commands-depl-7b9447fbb8-kdvtb    1/1     Running             1 (32h ago)   4d8h
mssql-depl-856b8c48fd-l2p6h       0/1     ContainerCreating   0             50s
platforms-depl-5b69dbc478-s7scc   1/1     Running             1 (32h ago)   4d8h

wait for mssql-depl

kubectl get pods
NAME                              READY   STATUS             RESTARTS      AGE
commands-depl-7b9447fbb8-kdvtb    1/1     Running            1 (32h ago)   4d8h
mssql-depl-856b8c48fd-l2p6h       0/1     CrashLoopBackOff   3 (30s ago)   6m21s
platforms-depl-5b69dbc478-s7scc   1/1     Running            1 (32h ago)   4d8h

kubectl get pods
NAME                              READY   STATUS    RESTARTS      AGE
commands-depl-7b9447fbb8-kdvtb    1/1     Running   1 (32h ago)   4d8h
mssql-depl-856b8c48fd-l2p6h       0/1     **Error**     4 (59s ago)   6m50s
platforms-depl-5b69dbc478-s7scc   1/1     Running   1 (32h ago)   4d8h

SQL Server 2019 will run as non-root by default.

This container is running as user root.

Your master database file is owned by root.

To learn more visit https://go.microsoft.com/fwlink/?linkid=2099216.

2022-02-11 08:15:13.16 Server      The licensing PID was successfully processed. The new edition is [Express Edition].

2022-02-11 08:15:13.55 Server      Microsoft SQL Server 2017 (RTM-CU28) (KB5008084) - 14.0.3430.2 (X64) 

Dec 17 2021 14:30:27 

Copyright (C) 2017 Microsoft Corporation

Express Edition (64-bit) on Linux (Ubuntu 16.04.7 LTS)

2022-02-11 08:15:13.56 Server      UTC adjustment: 0:00

2022-02-11 08:15:13.56 Server      (c) Microsoft Corporation.

2022-02-11 08:15:13.56 Server      All rights reserved.

2022-02-11 08:15:13.56 Server      Server process ID is 384.

2022-02-11 08:15:13.57 Server      Logging SQL Server messages in file '/var/opt/mssql/log/errorlog'.

2022-02-11 08:15:13.57 Server      Registry startup parameters: 

 -d /var/opt/mssql/data/master.mdf

 -l /var/opt/mssql/data/mastlog.ldf

 -e /var/opt/mssql/log/errorlog

2022-02-11 08:15:13.58 Server      SQL Server detected 1 sockets with 4 cores per socket and 4 logical processors per socket, 4 total logical processors; using 4 logical processors based on SQL Server licensing. This is an informational message; no user action is required.

2022-02-11 08:15:13.58 Server      SQL Server is starting at normal priority base (=7). This is an informational message only. No user action is required.

2022-02-11 08:15:13.59 Server      Detected 9550 MB of RAM. This is an informational message; no user action is required.

2022-02-11 08:15:13.59 Server      Using conventional memory in the memory manager.

2022-02-11 08:15:13.60 Server      Page exclusion bitmap is enabled.

2022-02-11 08:15:13.72 Server      Buffer pool extension is already disabled. No action is necessary. 

2022-02-11 08:15:13.93 Server      InitializeExternalUserGroupSid failed. Implied authentication will be disabled.

2022-02-11 08:15:13.93 Server      Implied authentication manager initialization failed. Implied authentication will be disabled.

2022-02-11 08:15:13.94 Server      Successfully initialized the TLS configuration. Allowed TLS protocol versions are ['1.0 1.1 1.2']. Allowed TLS ciphers are ['...'].

2022-02-11 08:15:13.97 Server      Query Store settings initialized with enabled = 1, 

2022-02-11 08:15:13.99 Server      The maximum number of dedicated administrator connections for this instance is '1'

2022-02-11 08:15:14.00 Server      Node configuration: node 0: CPU mask: 0x000000000000000f:0 Active CPU mask: 0x000000000000000f:0. This message provides a description of the NUMA configuration for this computer. This is an informational message only. No user action is required.

2022-02-11 08:15:14.03 Server      Using dynamic lock allocation.  Initial allocation of 2500 Lock blocks and 5000 Lock Owner blocks per node.  This is an informational message only.  No user action is required.

2022-02-11 08:15:14.04 Server      In-Memory OLTP initialized on lowend machine.

2022-02-11 08:15:14.07 Server      Database Instant File Initialization: enabled. For security and performance considerations see the topic 'Database Instant File Initialization' in SQL Server Books Online. This is an informational message only. No user action is required.

ForceFlush is enabled for this instance. 

2022-02-11 08:15:14.09 Server      Software Usage Metrics is disabled.

2022-02-11 08:15:14.10 spid5s      Starting up database 'master'.

ForceFlush feature is enabled for log durability.

2022-02-11 08:15:14.10 spid5s      3 transactions rolled forward in database 'master' (1:0). This is an informational message only. No user action is required.

2022-02-11 08:15:14.11 spid5s      0 transactions rolled back in database 'master' (1:0). This is an informational message only. No user action is required.

2022-02-11 08:15:14.11 spid5s      Recovery is writing a checkpoint in database 'master' (1). This is an informational message only. No user action is required.

2022-02-11 08:15:14.26 spid5s      Service Master Key could not be decrypted using one of its encryptions. See sys.key_encryptions for details.

2022-02-11 08:15:14.26 spid5s      An error occurred during Service Master Key initialization. SQLErrorCode=33095, State=8, LastOsError=0.

2022-02-11 08:15:14.34 spid5s      SQL Server Audit is starting the audits. This is an informational message. No user action is required.

2022-02-11 08:15:14.35 spid5s      SQL Server Audit has started the audits. This is an informational message. No user action is required.

2022-02-11 08:15:14.39 spid5s      SQL Trace ID 1 was started by login "sa".

2022-02-11 08:15:14.42 spid5s      Server name is 'mssql-depl-856b'. This is an informational message only. No user action is required.

2022-02-11 08:15:14.44 spid19s     Always On: The availability replica manager is starting. This is an informational message only. No user action is required.

2022-02-11 08:15:14.45 spid11s     Starting up database 'mssqlsystemresource'.

2022-02-11 08:15:14.45 spid19s     Always On: The availability replica manager is waiting for the instance of SQL Server to allow client connections. This is an informational message only. No user action is required.

2022-02-11 08:15:14.46 spid11s     The resource database build version is 14.00.3430. This is an informational message only. No user action is required.

2022-02-11 08:15:14.46 spid5s      Starting up database 'msdb'.

2022-02-11 08:15:14.52 spid11s     Starting up database 'model'.

2022-02-11 08:15:14.54 spid18s     A self-generated certificate was successfully loaded for encryption.

2022-02-11 08:15:14.56 spid18s     Server is listening on [ 'any' <ipv6> 1433].

2022-02-11 08:15:14.56 spid18s     Server is listening on [ 'any' <ipv4> 1433].

2022-02-11 08:15:14.56 spid18s     Dedicated administrator connection support was not started because it is disabled on this edition of SQL Server. If you want to use a dedicated administrator connection, restart SQL Server using the trace flag 7806. This is an informational message only. No user action is required.

2022-02-11 08:15:14.57 spid5s      1 transactions rolled forward in database 'msdb' (4:0). This is an informational message only. No user action is required.

2022-02-11 08:15:14.58 spid18s     SQL Server is now ready for client connections. This is an informational message; no user action is required.

2022-02-11 08:15:14.60 spid5s      0 transactions rolled back in database 'msdb' (4:0). This is an informational message only. No user action is required.

2022-02-11 08:15:14.64 spid11s     Polybase feature disabled.

2022-02-11 08:15:14.64 spid11s     Clearing tempdb database.

2022-02-11 08:15:14.78 spid11s     Starting up database 'tempdb'.

2022-02-11 08:15:14.98 spid19s     The Service Broker endpoint is in disabled or stopped state.

2022-02-11 08:15:14.99 spid19s     The Database Mirroring endpoint is in disabled or stopped state.

2022-02-11 08:15:15.01 spid19s     Service Broker manager has started.

2022-02-11 08:15:15.01 spid5s      Recovery is complete. This is an informational message only. No user action is required.

2022-02-11 08:15:15.21 spid31s     ERROR: Unable to set system administrator password: Password validation failed. The password does not meet SQL Server password policy requirements because it is too short. The password must be at least 8 characters..

2022-02-11 08:15:15.22 spid31s     An error occurred during server setup. See previous errors for more information.

2022-02-11 08:15:15.22 spid31s     SQL Trace was stopped due to server shutdown. Trace ID = '1'. This is an informational message only; no user action is required.



### kubectl describe pod mssql-depl-856b8c48fd-l2p6h
Name:         mssql-depl-856b8c48fd-l2p6h
Namespace:    default
Priority:     0
Node:         docker-desktop/192.168.65.4
Start Time:   Fri, 11 Feb 2022 10:08:26 +0200
Labels:       app=mssql
              pod-template-hash=856b8c48fd
Annotations:  <none>
Status:       Running
IP:           10.1.0.26
IPs:
  IP:           10.1.0.26
Controlled By:  ReplicaSet/mssql-depl-856b8c48fd
Containers:
  mssql:
    Container ID:   docker://4a4500f8b67e072f531ae5a0549c68b20ac5547e83fe62f9e8294064f70459bf
    Image:          mcr.microsoft.com/mssql/server:2017-latest
    Image ID:       docker-pullable://mcr.microsoft.com/mssql/server@sha256:71960de0371008d7994df5da6d0b33d45bcc2264d67d6a5d9e8573caf18216eb
    Port:           1433/TCP
    Host Port:      0/TCP
    State:          Waiting
      Reason:       CrashLoopBackOff
    Last State:     Terminated
      Reason:       Error
      Exit Code:    1
      Started:      Fri, 11 Feb 2022 10:24:48 +0200
      Finished:     Fri, 11 Feb 2022 10:24:55 +0200
    Ready:          False
    Restart Count:  7
    Environment:
      MSSQL_PID:    Express
      ACCEPT_EULA:  Y
      SA_PASSWORD:  <set to the key 'SA_PASSWORD' in secret 'mssql'>  Optional: false
    Mounts:
      /var/opt/mssql/data from mssqldb (rw)
      /var/run/secrets/kubernetes.io/serviceaccount from kube-api-access-78qbs (ro)
Conditions:
  Type              Status
  Initialized       True
  Ready             False
  ContainersReady   False
  PodScheduled      True
Volumes:
  mssqldb:
    Type:       PersistentVolumeClaim (a reference to a PersistentVolumeClaim in the same namespace)
    ClaimName:  mssql-claim
    ReadOnly:   false
  kube-api-access-78qbs:
    Type:                    Projected (a volume that contains injected data from multiple sources)
    TokenExpirationSeconds:  3607
    ConfigMapName:           kube-root-ca.crt
    ConfigMapOptional:       <nil>
    DownwardAPI:             true
QoS Class:                   BestEffort
Node-Selectors:              <none>
Tolerations:                 node.kubernetes.io/not-ready:NoExecute op=Exists for 300s
                             node.kubernetes.io/unreachable:NoExecute op=Exists for 300s
Events:
  Type     Reason     Age                   From               Message
  ----     ------     ----                  ----               -------
  Normal   Scheduled  20m                   default-scheduler  Successfully assigned default/mssql-depl-856b8c48fd-l2p6h to docker-desktop
  Normal   Pulling    20m                   kubelet            Pulling image "mcr.microsoft.com/mssql/server:2017-latest"
  Normal   Pulled     15m                   kubelet            Successfully pulled image "mcr.microsoft.com/mssql/server:2017-latest" in 4m40.784216s
  Normal   Created    13m (x5 over 15m)     kubelet            Created container mssql
  Normal   Started    13m (x5 over 15m)     kubelet            Started container mssql
  Normal   Pulled     13m (x4 over 15m)     kubelet            Container image "mcr.microsoft.com/mssql/server:2017-latest" already present on machine
  Warning  BackOff    4m53s (x45 over 15m)  kubelet            Back-off restarting failed container

  kubectl get pods
NAME                              READY   STATUS             RESTARTS        AGE
commands-depl-7b9447fbb8-kdvtb    1/1     Running            1 (33h ago)     4d8h
mssql-depl-856b8c48fd-l2p6h       0/1     CrashLoopBackOff   9 (4m24s ago)   31m
platforms-depl-5b69dbc478-s7scc   1/1     Running            1 (33h ago)     4d8h


2022-02-11 08:40:32.51 spid10s     ERROR: Unable to set system administrator password: Password validation failed. **The password does not meet SQL Server password policy requirements because it is too short.** The password must be at least 8 characters..


kubectl get secrets
NAME                  TYPE                                  DATA   AGE 
default-token-w69br   kubernetes.io/service-account-token   3      11d 
mssql                 Opaque                                1      174m

kubectl edit secret mssql
kubectl delete secret mssql

kubectl create secret generic mssql --from-literal=SA_PASSWORD="!"


kubectl delete secret mssql
secret "mssql" deleted

kubectl create secret generic mssql --from-literal=SA_PASSWORD="1!"
secret/mssql created

kubectl get pods
NAME                              READY   STATUS    RESTARTS      AGE
commands-depl-7b9447fbb8-kdvtb    1/1     Running   1 (34h ago)   4d9h
mssql-depl-856b8c48fd-l2p6h       1/1     **Running**   23            95m
platforms-depl-5b69dbc478-s7scc   1/1     Running   1 (34h ago)   4d10h



dotnet ef migrations add initialmigration
Could not execute because the specified command or file was not found.
Possible reasons for this include:
  * You misspelled a built-in dotnet command.
  * You intended to execute a .NET program, but dotnet-ef does not exist.
  * You intended to run a global tool, but a dotnet-prefixed executable with this name could not be found on the PATH.

dotnet tool install --global dotnet-ef
You can invoke the tool using the following command: dotnet-ef
Tool 'dotnet-ef' (version '6.0.2') was successfully installed.

dotnet ef migrations add initialmigration
Build started...
Build failed. Use dotnet build to see the errors.

Fake - trick - hack a little bit to do a migration
NB! Comment trick
https://youtu.be/DgVjEo3OGBI?t=20962



dotnet ef migrations add initialmigration

Build started...
Build succeeded.
--> Using SqlServer Db
--> Command Service endpoint: http://localhost:6000/api/c/platforms/
Done. To undo this action, use 'ef migrations remove'

Migrations was successfully added


### Rebuild and re-deploy

#### docker build -t dpoluektov/platformservice .

[+] Building 114.8s (15/15) FINISHED
 => [internal] load build definition from Dockerfile                                                                                                                                    0.1s 
 => => transferring dockerfile: 32B                                                                                                                                                     0.0s 
 => [internal] load .dockerignore                                                                                                                                                       0.0s 
 => => transferring context: 2B                                                                                                                                                         0.0s 
 => [internal] load metadata for mcr.microsoft.com/dotnet/aspnet:5.0                                                                                                                    1.2s 
 => [internal] load metadata for mcr.microsoft.com/dotnet/sdk:5.0                                                                                                                       1.2s 
 => [stage-1 1/3] FROM mcr.microsoft.com/dotnet/aspnet:5.0@sha256:1a84ffc93d5523c798709003b82e2bceb93cebede29fca7baa0f4569131ca5bc                                                     41.8s 
 => => resolve mcr.microsoft.com/dotnet/aspnet:5.0@sha256:1a84ffc93d5523c798709003b82e2bceb93cebede29fca7baa0f4569131ca5bc                                                              0.0s 
 => => sha256:1a84ffc93d5523c798709003b82e2bceb93cebede29fca7baa0f4569131ca5bc 2.17kB / 2.17kB                                                                                          0.0s 
 => => sha256:1b7ba605440ba0a6af08ef28a2f21880dbb2eba00c1b492c91dae04b7fadd6c0 1.37kB / 1.37kB                                                                                          0.0s 
 => => sha256:bbc2e8f37e4dabef0fdc806924cdac4ea32a1ee5382bb6e7e5aec304cb79d943 3.26kB / 3.26kB                                                                                          0.0s 
 => => sha256:21e1bc814f94da1eca203406382d30fbd728d1166b78eb1fe0ec7a656f20a98e 17.07MB / 17.07MB                                                                                       26.9s 
 => => sha256:a66d6e2c65058e95b041d887650090152518e48b9d189671c0372d74faf2c8fa 31.77MB / 31.77MB                                                                                       39.5s 
 => => sha256:1468e0fc777d4f3ab0db057f767dc4cb1e2a3b99c0e50cf387734281c4c72f2d 156B / 156B                                                                                              0.2s 
 => => sha256:52220ccf12d80755aeb587691202470b4306ce97e8d98b1701131d8036534862 8.65MB / 8.65MB                                                                                          6.5s 
 => => extracting sha256:21e1bc814f94da1eca203406382d30fbd728d1166b78eb1fe0ec7a656f20a98e                                                                                              86.3s 
 => => extracting sha256:a66d6e2c65058e95b041d887650090152518e48b9d189671c0372d74faf2c8fa                                                                                              73.8s 
 => => extracting sha256:1468e0fc777d4f3ab0db057f767dc4cb1e2a3b99c0e50cf387734281c4c72f2d                                                                                              72.4s 
 => => extracting sha256:52220ccf12d80755aeb587691202470b4306ce97e8d98b1701131d8036534862                                                                                              72.2s 
 => [build-env 1/6] FROM mcr.microsoft.com/dotnet/sdk:5.0@sha256:c5df98ac266e6cd2b94c3ac4e153d7e43db0a84b833b125cada852ec16edd752                                                      83.5s 
 => => resolve mcr.microsoft.com/dotnet/sdk:5.0@sha256:c5df98ac266e6cd2b94c3ac4e153d7e43db0a84b833b125cada852ec16edd752                                                                 0.0s 
 => => sha256:3bf64522be1de706f772ffe2c0f09fbc47d69bd5a9d2bb9583e16770e44feb0a 7.11kB / 7.11kB                                                                                          0.0s 
 => => sha256:c5df98ac266e6cd2b94c3ac4e153d7e43db0a84b833b125cada852ec16edd752 2.17kB / 2.17kB                                                                                          0.0s 
 => => sha256:500c6619a77f19fe8f4f28dbb21cae9c0c97ac0d494975560ecb3fbc70f59ab5 2.01kB / 2.01kB                                                                                          0.0s 
 => => sha256:1468e0fc777d4f3ab0db057f767dc4cb1e2a3b99c0e50cf387734281c4c72f2d 156B / 156B                                                                                              0.3s 
 => => sha256:a66d6e2c65058e95b041d887650090152518e48b9d189671c0372d74faf2c8fa 31.77MB / 31.77MB                                                                                       39.5s 
 => => sha256:21e1bc814f94da1eca203406382d30fbd728d1166b78eb1fe0ec7a656f20a98e 17.07MB / 17.07MB                                                                                       27.0s 
 => => sha256:52220ccf12d80755aeb587691202470b4306ce97e8d98b1701131d8036534862 8.65MB / 8.65MB                                                                                          6.5s 
 => => sha256:b28ec524fcbb6eca7f39478ccdebb07949ad1b159ea2a538b822e4a4b6d68e6a 27.56MB / 27.56MB                                                                                       22.5s 
 => => sha256:5f6a224134de6fc1eadc2f2413b70abfc7a91096eb93969e9d7d0a970f88f85d 105.64MB / 105.64MB                                                                                     77.8s 
 => => sha256:827871fe8cdef2e2c081b1e8890095e998930c4690595a496cdb5385421da351 12.69MB / 12.69MB                                                                                       44.3s 
 => => extracting sha256:21e1bc814f94da1eca203406382d30fbd728d1166b78eb1fe0ec7a656f20a98e                                                                                               0.8s
 => => extracting sha256:a66d6e2c65058e95b041d887650090152518e48b9d189671c0372d74faf2c8fa                                                                                               1.4s 
 => => extracting sha256:1468e0fc777d4f3ab0db057f767dc4cb1e2a3b99c0e50cf387734281c4c72f2d                                                                                               0.0s 
 => => extracting sha256:52220ccf12d80755aeb587691202470b4306ce97e8d98b1701131d8036534862                                                                                               0.4s 
 => => extracting sha256:b28ec524fcbb6eca7f39478ccdebb07949ad1b159ea2a538b822e4a4b6d68e6a                                                                                               1.6s 
 => => extracting sha256:5f6a224134de6fc1eadc2f2413b70abfc7a91096eb93969e9d7d0a970f88f85d                                                                                               4.7s 
 => => extracting sha256:827871fe8cdef2e2c081b1e8890095e998930c4690595a496cdb5385421da351                                                                                               0.6s 
 => [internal] load build context                                                                                                                                                       0.2s 
 => => transferring context: 1.73MB                                                                                                                                                     0.1s 
 => [stage-1 2/3] WORKDIR /app                                                                                                                                                          0.6s 
 => [build-env 2/6] WORKDIR /app                                                                                                                                                        1.0s 
 => [build-env 3/6] COPY *.csproj ./                                                                                                                                                    0.1s 
 => [build-env 4/6] RUN dotnet restore                                                                                                                                                 23.2s 
 => [build-env 5/6] COPY . ./                                                                                                                                                           0.3s 
 => [build-env 6/6] RUN dotnet publish -c Release -o out                                                                                                                                4.7s 
 => [stage-1 3/3] COPY --from=build-env /app/out .                                                                                                                                      0.3s 
 => exporting to image                                                                                                                                                                  0.3s 
 => => exporting layers                                                                                                                                                                 0.2s 
 => => writing image sha256:c72b19c0d7844a2750a1683e5e42782969cdeca3e08be0962f71c9de5224984f                                                                                            0.0s 
 => => naming to docker.io/dpoluektov/platformservice                                                                                                                                   0.0s 

Use 'docker scan' to run Snyk tests against images to find vulnerabilities and learn how to fix them


#### docker push dpoluektov/platformservice

Using default tag: latest
The push refers to repository [docker.io/dpoluektov/platformservice]
d5c13220badf: Pushed
e70d982eb423: Pushed
ac7127334263: Pushed
f403f6573e99: Pushed
8d650ca022e2: Pushed
068c0c45d9f4: Pushed
f18b02b14138: Layer already exists
latest: digest: sha256:15f6072ae5e9e0aa9576ac827008209269783e8f8946bbd816cdfa1449b7c4e5 size: 1789

Check it on https://hub.docker.com/


kubectl get deployments

NAME             READY   UP-TO-DATE   AVAILABLE   AGE
commands-depl    1/1     1            1           5d12h
mssql-depl       1/1     1            1           27h
**platforms-depl   1/1     1            1           12d**
(we did not change yaml so just restart)

kubectl rollout restart deployment platforms-depl

deployment.apps/platforms-depl restarted

kubectl get pods

NAME                              READY   STATUS    RESTARTS        AGE
commands-depl-7b9447fbb8-kdvtb    1/1     Running   1 (2d12h ago)   5d12h
mssql-depl-856b8c48fd-l2p6h       1/1     Running   24              27h
platforms-depl-657fd9b857-bg94x   1/1     Running   0               43s

kill deployment
https://youtu.be/DgVjEo3OGBI?t=21498

dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 5.0.0