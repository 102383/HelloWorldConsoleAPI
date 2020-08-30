using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.WriterFactory.Writers
{
    public class ConsoleWriter : IWriter
    {
        public string Write(string Message)
        {
            Console.WriteLine(Message + " - Written to Console.");
            return Message + " - Written to Console.";
        }
    }
}
