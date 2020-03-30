To setup the repo as a nuget source, run the following command in the Core root (where the `.csproj` is located):
```
dotnet nuget add source https://leveragerx.pkgs.visualstudio.com/LeverageRx/_packaging/BreezePackages/nuget/v3/index.json --name "BreezePackages" --username [username] --password [PAT]
```
---
To update the package in the feed, build the solution, then run the following command (don't forget to re-version it!):
```
dotnet nuget push --source "BreezePackages" --api-key az .\bin\Release\netcoreapp3.1\publish\DocuSign.eSign.Core.1.0.0.nupkg
```