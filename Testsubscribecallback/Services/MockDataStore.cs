using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testsubscribecallback.Models;

namespace Testsubscribecallback.Services
{
    public class MockDataStore
    {
        IList<Address> Addresses;

        public MockDataStore()
        {
            Addresses = new List<Address>();

            Addresses.Add(new Address
            {
                Id = Guid.NewGuid().ToString(),
                Street = "First St"
            });
            Addresses.Add(new Address
            {
                Id = Guid.NewGuid().ToString(),
                Street = "Second St"
            }) ;
        }

        public async Task<bool> AddItemAsync(Address item)
        {
            Addresses.Add(item);
            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Address item)
        {
            Address oldItem = Addresses.Where((Address arg) => arg.Id == item.Id).FirstOrDefault();
            Addresses.Remove(oldItem);
            Addresses.Add(item);
            return await Task.FromResult(true);

        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            Address oldItem = Addresses.Where((Address arg) => arg.Id == id).FirstOrDefault();
            Addresses.Remove(oldItem);
            return await Task.FromResult(true);
        }

        public async Task<Address> GetItemAsync(string id)
        {
            Address address = Addresses.Where((Address arg) => arg.Id == id).FirstOrDefault();
            return await Task.FromResult(address);
        }

        public async Task<IEnumerable<Address>> GetItemAsync(bool forceRefresh = true)
        {
            return await Task.FromResult(Addresses);
        }
    }
}
