### Models vs. DTOs

1:28 DTOs - external representations of our internal models.

You don't want to expose your internal models to external consumers
1) Data privacy
2) Contractual Coupling 
    If you change the model - you will break contract

=> Abstract internal data from external data

Read Dto - consumer gets
Create Dto - we expect

PlatformCreateDto 
- we don't require the id (for insert) 
- But we are using data annotations (for validation).

We will use Automapper to map them.

### Synchronous Messaging
For service-to-service you can use synchronous communication.
We will use asynchronous communication later.

* Request/Response Cycle
* Requester will "wait" for response
* Externally facing services usually synchronous (http requests)
* Synchronous Services usually need to "know" about each other
    Synchronous request to the endpoint.
* 2 forms of synchronous messaging:
    * Http
    * Grpc

Q: Wait! What if I mark controllers http actions as Async?
Does it making an async messaging?

A: **No!**
* From messging perspective this method is still synchronous.
* The client still has to wait for a response.
* Async in this context (the C# language) means that
    - **the action will not wait** for a long running operation
    - will not wait, 
    - will not hold this thread, 
    - will return thread back to the thread pool.
* When operation finishes it will re-acquire a thread and complete,
    and respond back to the requestor
* So Async here is about thread exhaustion 
    - the requestor still has to wait
    - the call is synchronous

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