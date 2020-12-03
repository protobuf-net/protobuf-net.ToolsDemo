using ProtoBuf;

namespace UsageDemo.Analyzers
{
    [ProtoContract]
    [ProtoReserved(1)]
    [ProtoReserved(1, 5)]
    public class BrokenModel
    {
        [ProtoMember(1)]
        public int X { get; set; }
    }
}
