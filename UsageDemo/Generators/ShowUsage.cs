using Grpc.Core;
using MyModelHere; // from the .proto file

using ProtoBuf;
using ProtoBuf.Grpc.Client;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace UsageDemo.Generators
{
    class ShowUsage
    {
        static async Task SomeMethod(CancellationToken cancellationToken = default)
        {
            var foo = new Foo
            {
                A = 42,
                B = "abc",
                C = { new Bar { Name = "def " } }
            };

            using var ms = new MemoryStream();
            Serializer.Serialize(ms, foo);
            var hex = BitConverter.ToString(ms.GetBuffer(), 0, (int)ms.Length);
            Console.WriteLine(hex);

            var channel = FakeGetChannel();
            var svc = channel.CreateGrpcService<ISomeService>();

            var reply = await svc.DoTheThingAsync(foo, cancellationToken);
        }
        static ChannelBase FakeGetChannel() => throw new NotImplementedException(); // using the Microsoft or Google gRPC libs
    }
}
