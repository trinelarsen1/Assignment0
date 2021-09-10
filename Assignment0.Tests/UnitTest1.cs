using System;
using System.IO;
using Xunit;

namespace Assignment0.Tests
{
    public class Programtests
    {
        [Fact]
        public void Test1()
        {
            // Arrange 
            var writer = new StringWriter(); 
            Console.SetOut(writer);

            //Act
            Program.Main(new string[0]);

            //Assert
            var output = writer.GetStringBuilder().ToString();
            Assert.Equal("Hello, World!", output);
        }
    }
}
