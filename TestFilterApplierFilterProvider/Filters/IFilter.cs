using System;
using System.Collections.Generic;
using System.Text;

namespace TestFilterApplierFilterProvider.Providers
{
    public interface IFilter
    {
        string Filter(string input);
    }
}
