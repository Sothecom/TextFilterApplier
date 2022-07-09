using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using TestFilterApplierFilterProvider.Providers;

namespace TextFilterApplierConsoleApp.Services
{
    public class FilterService : IFilterService
    {
        public string Filter(string input)
        {
            string returnValue = input;

            // Get all filter types
            var filterTypes = Assembly.GetAssembly(typeof(FilterService)).GetTypes()
                            .Where(t => t.IsInstanceOfType(typeof(IFilter)));

            // Foreach type, apply filter to string (chain up)
            foreach (var filterType in filterTypes)
            {
                var filter = filterType.Assembly.CreateInstance(filterType.Name) as IFilter;
                returnValue = filter.Filter(returnValue);
            }

            return returnValue;
        }
    }
}
