using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using TextFilterApplierConsoleApp.Services;

namespace Tests.TextFilterApplierIntegrationTests
{
    [TestClass]
    public class FileTextFilterApplierIntegrationTests
    {
        [TestMethod]
        public void GivenTextFile_WhenFilterApplied_GetExpectedResult()
        {
            string inputFileName = "TestData/TestInput.txt";
            string expectedResultFileName = "TestData/ExpectedOutput.txt";

            string textToFilter = GetFileContents(inputFileName);
            string expectedResult = GetFileContents(expectedResultFileName); ;

            FilterService filterService = new FilterService();
            string actualResult = filterService.Filter(textToFilter);

            Assert.AreEqual(expectedResult, actualResult);
        }

        private static string GetFileContents(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                return sr.ReadToEnd();
            }
        }
    }
}
