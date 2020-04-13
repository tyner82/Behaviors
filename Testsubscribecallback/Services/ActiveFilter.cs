using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Testsubscribecallback.Services
{
    public class ActiveFilter
    {
        List<string> activeFilters;

        public ActiveFilter() => activeFilters = new List<string>();

        public void AddFilter(string filter)
        {
            Console.WriteLine($"Host is Adding filter{filter}\n{activeFilters.GetHashCode()}");
            activeFilters.Add(filter);
        }

        async public Task<List<string>> Filters()
        {
            Console.WriteLine($"In Filters()\n{activeFilters.GetHashCode()}");
            Console.WriteLine($"FiltersCount = {activeFilters.Count}");
            return await Task.FromResult(activeFilters);
        }
    }
}
