using System.Linq;
using System.Text;
using TextFilterApplierFilterProvider.Filters;

namespace TextFilterApplierFilterProviderUnitTests
{
    public class ForbiddenLetterTFilter : ICalTextFilter
    {
        public string Filter(string input)
        {
            string returnValue = string.Empty;
            var wordsList = input.Split(' ').ToList();
            StringBuilder sb = new StringBuilder();

            wordsList.ForEach(word =>
            {
                if (!word.ToLower().Contains('t'))
                {
                    sb.Append(word + ' ');
                }
            });

            returnValue = sb.ToString(); // with trailing space

            return returnValue.Remove(returnValue.Length - 1);
        }
    }
}