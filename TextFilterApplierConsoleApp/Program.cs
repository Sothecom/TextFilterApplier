using System;
using System.IO;
using TextFilterApplierConsoleApp.Services;

namespace TextFilterApplierConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "TextInput.txt";

            if (args.Length > 0)
            {
                fileName = args[0];
            }

            string textToFilter = GetFileContents(fileName);

            FilterService filterService = new FilterService();
            string result = filterService.Filter(textToFilter);
            Console.WriteLine(result);
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
