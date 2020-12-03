# Analyzers

The BrokenModel.cs file demonstrates a protobuf-net model that has a few minor glitches; the glitches are
reported as errors/warnings/info/etc during build.

This works because the csproj includes the protobuf-net.BuildTools for use at build-time