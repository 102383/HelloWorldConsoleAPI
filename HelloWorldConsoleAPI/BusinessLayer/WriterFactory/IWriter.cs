using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.WriterFactory
{
    public interface IWriter
    {
        string Write(string Message);
    }
}
