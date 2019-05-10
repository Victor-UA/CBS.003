using System.IO;
using CBS._003.Task01.StreamWriters.Interfaces;

namespace CBS._003.Task01.StreamWriters
{
    public class UnderlineStreamWriter : BasicStreamWriter
    {
        public UnderlineStreamWriter(StreamWriter streamWriter) : base(streamWriter) { }
        public UnderlineStreamWriter(IStreamWriter writer) : base(writer) { }
        public UnderlineStreamWriter(Stream stream) : base(stream) { }

        protected override string ProcessString(string value)
        {
            return value.Replace(" ", "_");
        }
    }
}
