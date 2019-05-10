using System.IO;
using CBS._003.Task01.StreamWriters.Interfaces;

namespace CBS._003.Task01.StreamWriters
{
    public class UpperCaseStreamWriter : BasicStreamWriter
    {
        public UpperCaseStreamWriter(StreamWriter streamWriter) : base(streamWriter) { }
        public UpperCaseStreamWriter(IStreamWriter writer) : base(writer) { }
        public UpperCaseStreamWriter(Stream stream) : base(stream) { }

        protected override string ProcessString(string value)
        {
            return value.ToUpper();
        }
    }
}
