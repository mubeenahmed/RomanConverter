using NUnit.Framework;
using RomanConverter;
using System.Collections.Generic;

namespace RomanConverterTest
{
    public class Tests
    {

        [Test]
        public void RomanValidTest()
        {
            Assert.AreEqual(10, Program.Parser("x"));
            Assert.AreEqual(11, Program.Parser("xi"));
            Assert.AreEqual(9, Program.Parser("ix"));
            Assert.AreEqual(4, Program.Parser("iv"));
            Assert.AreEqual(6, Program.Parser("vi"));

            Assert.AreEqual(3724, Program.Parser("MMMDCCXXIV"));
            Assert.AreEqual(3769, Program.Parser("MMMDCCLXIX"));
            Assert.AreEqual(3, Program.Parser("III"));
        }

        [Test]
        public void InvalidRomanTest()
        {
            Assert.Throws<KeyNotFoundException>(() => Program.Parser("ABC"));
        }
    }
}