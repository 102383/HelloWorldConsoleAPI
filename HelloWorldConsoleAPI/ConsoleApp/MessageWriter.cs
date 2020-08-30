using BusinessLayer.WriterFactory;

namespace ConsoleApp
{
    public static class MessageWriter
    {
        public static string WriteHelloWorld(string target, string message)
        {
            IWriter writer = WriterFactory.Get(target);
            return writer.Write(message);
        }
    }
}
