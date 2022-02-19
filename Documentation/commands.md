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

# Commands Service 
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
dotnet add package Microsoft.EntityFrameworkCore --version 5.0.0
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.0
dotnet add package Microsoft.EntityFrameworkCore.InMemory

dotnet new gitignore

code -r CommandsService

## Commands Service -> Kube

docker build -t dpoluektov/commandsservice .

docker push dpoluektov/commandsservice

docker run -p 8080:80 -d dpoluektov/commandsservice

# re-build and re-deploy
docker build -t dpoluektov/platformservice .
docker push dpoluektov/platformservice
kubectl get deployments
kubectl rollout restart deployment platforms-depl
kubectl get pods

kubectl apply -f rabbitmq-depl.yaml
kubectl get services
kubectl get deployments
kubectl get pods

Goto browser (rabbitmq admin page):
http://localhost:15672/
guest/guest

dotnet add package RabbitMQ.Client

