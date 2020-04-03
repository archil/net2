using FirstMVCApp.Services;
using Moq;
using NUnit.Framework;
using System.Net.WebSockets;
using System.Runtime.InteropServices.ComTypes;

namespace FirstMVCApp.Test
{
    public class Tests
    {
        Mock<IDbAccess> sharedMoq = new Mock<IDbAccess>();

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestProcessor()
        {
            //Arrange
            var dbAccess = new Mock<IDbAccess>();

            //Act
            new Processor(dbAccess.Object).Process(5, 6);

            //Assert
            dbAccess.Verify(inp => inp.Save(It.IsAny<int>()), Times.AtLeastOnce());
        }
    }
}