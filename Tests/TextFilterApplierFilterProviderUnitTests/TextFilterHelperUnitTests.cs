using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

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
            string actualResult = string.Empty;
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        [DataRow("Forces", "rc")]
        public void GivenAnEvenLengthStringGreaterThan1_WhenGetMiddle_ThenGet2MiddleLetters(string input, string expectedResult)
        {
            string actualResult = string.Empty;
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        [DataRow("b", "b")]
        public void GivenAnOddLengthStringLessThan2_WhenGetMiddleApplied_ThenGetSameLetter(string input, string expectedResult)
        {
            string actualResult = string.Empty;
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        [DataRow("wd", "wd")]
        public void GivenAnEvenLengthStringLessThan3_WhenGetMiddleApplied_GetSame2MiddleLetters(string input, string expectedResult)
        {
            string actualResult = string.Empty;
            Assert.AreEqual(actualResult, expectedResult);
        }
        #endregion

        #region Length Less Than Helper Tests
        [TestMethod]
        [DataRow("Tony", 3, true)]
        [DataRow("Ja", 3, false)]
        [DataRow("Mutai", 4, true)]
        public void GivenAString_WhenLengthAllowedCheckMade_ReturnsExpectedBooleanResult(string input, int maxallowed, bool expectedResult)
        {
            bool actualResult = input.Length >= maxallowed;
            Assert.AreEqual(expectedResult, actualResult);
        }
        #endregion

        #region String contains string helper Tests
        [TestMethod]
        [DataRow("Tony", "t", false)]
        [DataRow("tony", "t", true)]
        [DataRow("Ja", "t", false)]
        [DataRow("Helper", "Help", true)]
        [DataRow("Case Sensitive", "se S", true)]
        public void GivenAString_WhenViolatesForbiddenStringCheckMade_ReturnsExpectedBooleanResult(string input, string forbiddenString, bool expectedResult)
        {
            bool actualResult = input.Contains(forbiddenString);
            Assert.AreEqual(expectedResult, actualResult);
        }
        #endregion
    }
}
