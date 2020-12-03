# Generators

The Model.proto file here is a protobuf schema that declares some types; they are not declared in our C# code anywhere,
but we can use them just fine from ShowUsage.cs

This works because:

1. Model.proto is marked as a "C# analyzer additional file" (`<AdditionalFiles>` in the csproj)
2. The csproj includes the protobuf-net.BuildTools for use at build-time