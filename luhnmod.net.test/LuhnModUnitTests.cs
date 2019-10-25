using NUnit.Framework;
using System;
using LuhnModN;

namespace LuhnModN.Test
{
    public class Tests
    {
        LuhnModN testInstance;
        [SetUp]
        public void Setup()
        {
            testInstance = new LuhnModN("abcdef");
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(testInstance.GenerateCheckDigit("abcdef"), 'e');
        }
        
        [Test]
        public void Test2()
        {
            Assert.IsTrue(testInstance.CheckValue("abcdefe"));
        }
    }
}
