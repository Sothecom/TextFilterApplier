using System;
using System.Linq;
using System.Text;
using TextFilterApplierFilterProvider.Helpers;

namespace TextFilterApplierFilterProvider.Filters
{
    public class MiddleVowelFilter : ICalTextFilter
    {
        public string Filter(string input)
        {
            var wordsArray = input.Split(' ').ToList();
            var vowels = "aeiou";
            string returnValue = string.Empty;
            StringBuilder sb = new StringBuilder();

            wordsArray.ForEach(word => 
            {
                string wordMiddle = MiddleVowelFilterHelper.GetMiddleCharacters(word);
                bool noVowel = true;

                for (int i = 0; i < wordMiddle.Length; i++)
                {
                    if (vowels.Contains(wordMiddle.Substring(i,1).ToLower()))
                    {
                        noVowel = false;
                        continue;
                    }
                }

                if (noVowel)
                {
                    sb.Append(word + ' ');
                }
            });

            returnValue = sb.ToString(); // with trailing space

            return returnValue.Remove(returnValue.Length-1);
        }
    }
}
