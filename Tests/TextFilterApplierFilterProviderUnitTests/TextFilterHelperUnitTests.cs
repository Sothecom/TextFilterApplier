using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextFilterApplierFilterProvider.Helpers;

namespace Tests.TextFilterApplierFilterProviderUnitTests
{
    [TestClass]
    public class TextFilterHelperUnitTests
    {
        #region Middle of word tests
        [TestMethod]
        [DataRow("The", "h")]
        public void GivenAnOddLengthStringGreaterThan2_WhenGetMiddle_ThenGet1MiddleLetter(string input, string expectedResult)
        {
            string actualResult = MiddleVowelFilterHelper.GetMiddleCharacters(input);
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        [DataRow("Forces", "rc")]
        public void GivenAnEvenLengthStringGreaterThan1_WhenGetMiddle_ThenGet2MiddleLetters(string input, string expectedResult)
        {
            string actualResult = MiddleVowelFilterHelper.GetMiddleCharacters(input);
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        [DataRow("b", "b")]
        public void GivenAnOddLengthStringLessThan2_WhenGetMiddleApplied_ThenGetSameLetter(string input, string expectedResult)
        {
            string actualResult = MiddleVowelFilterHelper.GetMiddleCharacters(input);
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        [DataRow("wd", "wd")]
        public void GivenAnEvenLengthStringLessThan3_WhenGetMiddleApplied_GetSame2MiddleLetters(string input, string expectedResult)
        {
            string actualResult = MiddleVowelFilterHelper.GetMiddleCharacters(input);
            Assert.AreEqual(actualResult, expectedResult);
        }
        #endregion
    }
}
