using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.WriterFactory.Writers
{
    public class DatabaseWriter : IWriter
    {
        public string Write(string Message)
        {
            //TODO: Database integration
            return Message + " - Written to Database.";
        }
    }
}
