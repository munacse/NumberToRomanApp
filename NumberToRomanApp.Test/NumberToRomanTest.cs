using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberToRomanApp.Test
{
    [TestClass]
    public class NumberToRomanTest
    {
        //https://spanishnumbers.guide/roman-numerals/
        [TestMethod]
        public void TestMethod_1_I()
        {
            Assert.AreEqual("I", NumbertoRomanParser.NumberToRoman(1));
        }

        [TestMethod]
        public void TestMethod_9_IX()
        {
            Assert.AreEqual("IX", NumbertoRomanParser.NumberToRoman(9));
        }

        [TestMethod]
        public void TestMethod_10_X()
        {
            Assert.AreEqual("X", NumbertoRomanParser.NumberToRoman(10));
        }

        [TestMethod]
        public void TestMethod_49_XLIX()
        {
            Assert.AreEqual("XLIX", NumbertoRomanParser.NumberToRoman(49));
        }

        [TestMethod]
        public void TestMethod_50_L()
        {
            Assert.AreEqual("L", NumbertoRomanParser.NumberToRoman(50));
        }

        [TestMethod]
        public void TestMethod_400_CD()
        {
            Assert.AreEqual("CD", NumbertoRomanParser.NumberToRoman(400));
        }

        [TestMethod]
        public void TestMethod_500_D()
        {
            Assert.AreEqual("D", NumbertoRomanParser.NumberToRoman(500));
        }

        [TestMethod]
        public void TestMethod_900_CM()
        {
            Assert.AreEqual("CM", NumbertoRomanParser.NumberToRoman(900));
        }

        [TestMethod]
        public void TestMethod_1000_M()
        {
            Assert.AreEqual("M", NumbertoRomanParser.NumberToRoman(1000));
        }

        [TestMethod]
        public void TestMethod_2999_MMCMXCIX()
        {
            Assert.AreEqual("MMCMXCIX", NumbertoRomanParser.NumberToRoman(2999));
        }

        [TestMethod]
        public void TestMethod_4000_MV()
        {
            Assert.AreEqual("MV", NumbertoRomanParser.NumberToRoman(4000));
        }

        [TestMethod]
        public void TestMethod_4989_MVCMLXXXIX()
        {
            Assert.AreEqual("MVCMLXXXIX", NumbertoRomanParser.NumberToRoman(4989));
        }

        [TestMethod]
        public void TestMethod_6000_VM()
        {
            Assert.AreEqual("VM", NumbertoRomanParser.NumberToRoman(6000));
        }

        [TestMethod]
        public void TestMethod_6666_VMDCLXVI()
        {
            Assert.AreEqual("VMDCLXVI", NumbertoRomanParser.NumberToRoman(6666));
        }

        [TestMethod]
        public void TestMethod_7777_VMMDCCLXXVII()
        {
            Assert.AreEqual("VMMDCCLXXVII", NumbertoRomanParser.NumberToRoman(7777));
        }

        [TestMethod]
        public void TestMethod_8787_VMMMDCCLXXXVII()
        {
            Assert.AreEqual("VMMMDCCLXXXVII", NumbertoRomanParser.NumberToRoman(8787));
        }

        [TestMethod]
        public void TestMethod_9000_MX()
        {
            Assert.AreEqual("MX", NumbertoRomanParser.NumberToRoman(9000));
        }

        [TestMethod]
        public void TestMethod_9999_MXCMXCIX()
        {
            Assert.AreEqual("MXCMXCIX", NumbertoRomanParser.NumberToRoman(9999));
        }

        [TestMethod]
        public void TestMethod_10000_X()
        {
            Assert.AreEqual("X", NumbertoRomanParser.NumberToRoman(10000));
        }

        [TestMethod]
        public void TestMethod_15000_OutOfRange()
        {
            Assert.AreEqual("Out of Range", NumbertoRomanParser.NumberToRoman(15000));
        }
    }
}
