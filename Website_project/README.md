# Prerequisites

- Install .Net 8 SDK, https://dotnet.microsoft.com/en-us/download/dotnet/8.0
- Install  PowerShell, https://learn.microsoft.com/en-us/powershell/scripting/install/installing-powershell-on-windows?view=powershell-7.4

After cloning the project, the following packages need to be added, either via NuGet package manager or with the following commands via the terminal: 

- dotnet add package Microsoft.NET.Test.Sdk
- dotnet add package Microsoft.Playwright
- dotnet add package xunit 
- dotnet add package xunit.runner.visualstudio 

Build the project using the following command in the terminal: 
dotnet build

After the solutions build successfully, navigate to the Website_project directory (containing the bin folder), and run the following command in the terminal:

pwsh bin/Debug/net8.0/playwright.ps1 install

This will install the Playwright browsers needed to execute the web test.

Tests can be executed using the Test Explorer in Visual Studio, or by running the 'dotnet test' command in the terminal.
