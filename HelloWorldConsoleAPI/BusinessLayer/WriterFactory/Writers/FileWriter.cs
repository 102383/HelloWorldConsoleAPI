using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.WriterFactory.Writers
{
    public class FileWriter : IWriter
    {
        public string Write(string Message)
        {
            //TODO: File integration
            return Message + " - Written to File.";
        }
    }
}
