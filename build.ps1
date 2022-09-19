rm -rf generated

dotnet run --project frosting/Build.csproj -- $args
exit $LASTEXITCODE;