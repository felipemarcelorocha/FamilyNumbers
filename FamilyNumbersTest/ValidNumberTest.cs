using FamilyNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FamilyNumbersTest
{
    [TestClass]
    public class ValidNumberTest
    {

        [TestMethod]
        public void IsValidNumber_WhenMaxLimitedIsExceeded_ShouldReturnInvalidNumber()
        {
            string number = "1000000000";

            bool expectedResult = false;

            bool result = ValidNumber.isValidNumber(number);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void IsValidNumber_WhenMinLimitedIsExceeded_ShouldReturnInvalidNumber()
        {
            string number = "-230";

            bool expectedResult = false;

            bool result = ValidNumber.isValidNumber(number);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
