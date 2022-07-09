using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using TestFilterApplierFilterProvider.Providers;

namespace TextFilterApplierConsoleApp.Services
{
    public class FilterServices : IFilterService
    {
        public string Filter(string input)
        {
            string returnValue = input;

            // Get all filter types
            var filters = Assembly.GetAssembly(typeof(FilterServices)).GetTypes()
                            .Where(t => t.IsInstanceOfType(typeof(IFilter)));

            // Foreach type, apply filter to string (chain up)
            foreach (var item in filters)
            {
                var filterMethod = item.GetMethod("Filter");
                returnValue = filterMethod.Invoke(null, new object[] { returnValue }).ToString();
            }

            return returnValue;
        }
    }
}
