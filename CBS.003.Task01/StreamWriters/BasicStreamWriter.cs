using CBS._003.Task01.StreamWriters.Interfaces;
using System.IO;

namespace CBS._003.Task01.StreamWriters
{
    public abstract class BasicStreamWriter: IStreamWriter
    {
        protected StreamWriter _nativeWriter = null;
        protected IStreamWriter _writer = null;


        public BasicStreamWriter(StreamWriter streamWriter)
        {
            _nativeWriter = streamWriter;
        }

        public BasicStreamWriter(IStreamWriter writer)
        {
            _writer = writer;
        }
        public BasicStreamWriter(Stream stream) : this(new StreamWriter(stream)) { }


        public void WriteLine(string value)
        {
            if (_writer != null)
            {
                _writer?.WriteLine(ProcessString(value));
            }
            else
            {
                _nativeWriter.WriteLine(ProcessString(value));
            }
        }

        protected virtual string ProcessString(string value)
        {
            return value;
        }


        public void Dispose()
        {
            _nativeWriter?.Dispose();
            _writer?.Dispose();
        }
    }
}
