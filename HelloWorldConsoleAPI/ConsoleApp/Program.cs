using System;
using System.Configuration;
using System.Reflection;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string target = ConfigurationManager.AppSettings["target"];
            string message = ConfigurationManager.AppSettings["message"];
            MessageWriter.WriteHelloWorld(target, message);
        }
    }
}
