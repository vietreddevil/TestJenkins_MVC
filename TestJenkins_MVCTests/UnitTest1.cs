using NUnit.Framework;
using System;
using System.IO;

namespace TestJenkins_MVCTests
{
    public class Tests
    {
        private const string Expected = "Hello World!";
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Assert.Pass();
            using (var sw = new StringWriter())
            { 
            }
        }
    }
}