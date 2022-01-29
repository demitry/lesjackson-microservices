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