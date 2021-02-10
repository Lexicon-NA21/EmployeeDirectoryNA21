using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeDirectoryNA21;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;

namespace EmployeeDirectoryNA21.Tests
{
    [TestClass()]
    public class UtilTests
    {
        private Mock<IUI> ui;

        [TestInitialize]
        public void Init()
        {
            ui = new Mock<IUI>();
        }

        [TestMethod()]
        public void AskForString_ReturnsString()
        {
            const string expected = "Kalle";
            ui.Setup(u => u.GetInput()).Returns(expected);

            var actual = Util.AskForString("Name: ", ui.Object);

            Assert.AreEqual(expected, actual);

        }
        
        [TestMethod()]
        [DataRow("5")]
        [DataRow("10")]
        [DataRow("15")]
        [DataRow("25")]
        public void AskForInt_ReturnsExpected(string value)
        {
            string expected = value;
            ui.Setup(u => u.GetInput()).Returns(expected);

            var actual = Util.AskForInt("Name: ", ui.Object);

            Assert.AreEqual(int.Parse(expected), actual);

        }




        [TestCleanup]
        public void CleanUp()
        {
            ui = null;
        }
    }
}