dotnet --version

dotnet new webapi -n PlatformService

code -r PlatformService

dotnet new gitignore

dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection

dotnet add package Microsoft.EntityFrameworkCore --version 5.0.0

dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.0

dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 5.0.0

dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.0

dotnet build

dotnet run

### Docker

build image:

docker build -t dpoluektov/platformservice .

run image as a container

docker run -p 8080:80 -d dpoluektov/platformservice

docker ps

docker stop b766a603c0fd

docker ps

docker run -p 8080:80 -d dpoluektov/platformservice
docker stop 36250effbb80
 - different container 

docker start b766a603c0fd

docker push dpoluektov/platformservice

### Kubernetes

kubectl version

kubectl apply -f platforms-depl.yaml  

kubectl get deployments

kubectl get pods

kubectl delete deployment platforms-depl


kubectl apply -f platforms-np-srv.yaml

kubectl get services