FROM mcr.microsoft.com/dotnet/core/runtime:2.2
COPY NameApi/bin/Release/netcoreapp2.2/publish/ NameApi/

ENTRYPOINT ["dotnet", "NameApi/NameApi.dll"]

