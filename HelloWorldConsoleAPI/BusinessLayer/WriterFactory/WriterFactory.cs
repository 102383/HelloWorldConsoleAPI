using BusinessLayer.WriterFactory.Writers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.WriterFactory
{
    public class WriterFactory
    {
        public enum WriterType
        { 
            File,
            Database,
            Console
        }

        public static IWriter Get(string type) {

            WriterType enumType = (WriterType)System.Enum.Parse(typeof(WriterType), type);

            switch (enumType) {
                case WriterType.Database:
                    return new DatabaseWriter();
                case WriterType.Console:
                    return new ConsoleWriter();
                case WriterType.File:
                    return new FileWriter();
                default:
                    throw new Exception(type + " is an invalid WriterType!");
            }
        }
    }
}
