using System;

namespace CBS._003.Task01.StreamWriters.Interfaces
{
    public interface IStreamWriter: IDisposable
    {
        void WriteLine(string value);
    }
}
