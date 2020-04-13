using System;
namespace Testsubscribecallback.Models
{
    public class Address
    {
        public string Id { get; set; }
        public string Street { get; set; }
        public override string ToString()
        {
            return $"{Id} {Street}";
        }
    }
}
