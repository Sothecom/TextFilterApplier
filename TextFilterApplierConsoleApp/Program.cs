using System;
using TextFilterApplierConsoleApp.Services;

namespace TextFilterApplierConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FilterService filterService = new FilterService();
            string result = filterService.Filter("The Force be with you");
            Console.WriteLine(result);
        }
    }
}
