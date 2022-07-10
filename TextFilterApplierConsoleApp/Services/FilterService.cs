using System.Linq;
using System.Reflection;
using TextFilterApplierFilterProvider.Filters;

namespace TextFilterApplierConsoleApp.Services
{
    public class FilterService : IFilterService
    {
        public string Filter(string input)
        {
            string returnValue = input;

            // Get all filter types
            var filterTypes = Assembly.GetAssembly(typeof(ICalTextFilter)).GetTypes()
                            .Where(t => t.IsClass && t.Name.EndsWith("Filter")) 
                            .ToList();

            // Foreach type, apply filter to string (chain up)
            foreach (var filterType in filterTypes)
            {
                var filter = filterType.Assembly.CreateInstance(filterType.FullName) as ICalTextFilter;
                returnValue = filter.Filter(returnValue);
            }

            return returnValue;
        }
    }
}
