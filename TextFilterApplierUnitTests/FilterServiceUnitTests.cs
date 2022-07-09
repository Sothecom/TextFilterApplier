using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.TextFilterApplierTestProject
{
    [TestClass]
    public class FilterServiceUnitTests
    {

        [TestMethod]
        [DataRow("The Force be with you", "The Force")]
        [DataRow("You can't handle the truth", "handle the")]
        [DataRow("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
                    "Lorem ipsum dolor, consectetur eiusmod tempor")]
        public void GivenAnOddLengthStringWithSpaces_WhenFilterApplied_ThenGetExpectedResults(string testString, string resultString)
        {
            Assert.AreEqual(testString, resultString);
        }

    }
}
