using FamilyNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FamilyNumbersTest
{
    [TestClass]
    public class GetNumberTest
    {
        [TestMethod]
        public void GetBiggestBrotherNumber_WhenValidNumberIsInsert_ShouldReturnBiggestCombination()
        {
            string number = "355";

            string expectedResult = "553";

            string result = GetNumber.getBiggestBrotherNumber(number);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
