using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextFilterApplierConsoleApp.Services;

namespace Tests.TextFilterApplierTestProject
{
    [TestClass]
    public class FilterServiceUnitTests
    {
        FilterService filterService;
        public FilterServiceUnitTests()
        {
            filterService = new FilterService();
        }

        [TestMethod]
        [DataRow("The Force be with you", "Force")]
        [DataRow("You can't handle the truth", "handle")]
        [DataRow("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
                    "Lorem ipsum dolor eiusmod")]
        public void GivenAnOddLengthStringWithSpaces_WhenFilterApplied_ThenGetExpectedResults(string input, string expectedResult)
        {
            string actualResult = filterService.Filter(input);
            Assert.AreEqual(actualResult, expectedResult);
        }

    }
}
