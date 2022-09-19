echo $PWD

rm -rf generated

dotnet run --project ./frosting/Build.csproj -- "$@ --base-path=$PWD"
