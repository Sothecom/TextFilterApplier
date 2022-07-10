using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextFilterApplierFilterProvider.Filters;

namespace TextFilterApplierFilterProviderUnitTests
{
    [TestClass]
    public class TextFilterUnitTests
    {
        [TestMethod]
        [DataRow("The force be with you Luke", "The force")]
        public void GivenSomeText_WhenVowelFilterApplied_GetFileredText(string input, string expectedResult)
        {
            string actualResult = new MiddleVowelFilter().Filter(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataRow("The force be with you Luke", "The force with you Luke")]
        public void GivenSomeText_WhenLessThan3FilterApplied_GetFileredText(string input, string expectedResult)
        {
            string actualResult = new LessThan3Filter().Filter(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataRow("The force be with you Luke", "force be you Luke")]
        public void GivenSomeText_WhenForbiddenLetterFilterApplied_GetFileredText(string input, string expectedResult)
        {
            string actualResult = new ForbiddenLetterTFilter().Filter(input);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
