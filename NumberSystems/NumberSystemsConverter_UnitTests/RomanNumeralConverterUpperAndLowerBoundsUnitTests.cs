using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using NumberSystemsConverter;
namespace NumberSystemsConverter_UnitTests
{
    [TestClass]
    public class RomanNumeralConverterUpperAndLowerBoundsUnitTests
    {
        [TestMethod]        
        public void Number_Greater_3000_Test()
        {
            var converter = new RomanNumeralConverter();         
            Assert.ThrowsException<IndexOutOfRangeException>(()=> converter.ConvertRomanNumeral(3001));
        }

        [TestMethod]
        public void Number_Less_Than_1_Test()
        {
            var converter = new RomanNumeralConverter();
            Assert.ThrowsException<IndexOutOfRangeException>(() => converter.ConvertRomanNumeral(-1));
        }

        [TestMethod]
        public void Number_Zero_Test()
        {
            var converter = new RomanNumeralConverter();
            Assert.ThrowsException<IndexOutOfRangeException>(() => converter.ConvertRomanNumeral(0));
        }
    }
}
