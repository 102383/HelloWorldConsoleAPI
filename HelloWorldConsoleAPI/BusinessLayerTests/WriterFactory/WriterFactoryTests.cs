using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer.WriterFactory;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Sdk;
using static BusinessLayer.WriterFactory.WriterFactory;
using BusinessLayer.WriterFactory.Writers;

namespace BusinessLayer.WriterFactory.Tests
{
    [TestClass()]
    public class WriterFactoryTests
    {
        [TestMethod()]
        public void GetTest_Console()
        {
            Assert.IsInstanceOfType(WriterFactory.Get("Console"), typeof(ConsoleWriter));
        }

        [TestMethod()]
        public void GetTest_File()
        {
            Assert.IsInstanceOfType(WriterFactory.Get("File"), typeof(FileWriter));
        }

        [TestMethod()]
        public void GetTest_Database()
        {
            Assert.IsInstanceOfType(WriterFactory.Get("Database"), typeof(DatabaseWriter));
        }
    }
}