cls
NuGet.exe pack ..\src\NuGet.Server.Core\NuGet.Server.Core.csproj -Build -Symbols -Properties Configuration=Release
NuGet.exe pack ..\src\NuGet.Server.V2\NuGet.Server.V2.csproj -Build -Symbols -Properties Configuration=Release
pause