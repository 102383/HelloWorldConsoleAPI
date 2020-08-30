using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Tests
{
    [TestClass()]
    public class MessageWriterTests
    {
        [TestMethod()]
        public void WriteHelloWorldTest_Console()
        {
            Assert.AreEqual(MessageWriter.WriteHelloWorld("Console", "TestMessage"), "TestMessage - Written to Console.");
        }

        [TestMethod()]
        public void WriteHelloWorldTest_File()
        {
            Assert.AreEqual(MessageWriter.WriteHelloWorld("File", "TestMessage"), "TestMessage - Written to File.");
        }

        [TestMethod()]
        public void WriteHelloWorldTest_Database()
        {
            Assert.AreEqual(MessageWriter.WriteHelloWorld("Database", "TestMessage"), "TestMessage - Written to Database.");
        }
    }
}