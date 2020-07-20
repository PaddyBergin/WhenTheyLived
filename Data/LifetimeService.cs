using System;
using System.Linq;
using System.Threading.Tasks;

namespace WhenTheyLived.Data
{
    public class LifetimeService
    {
        public Task<Lifetime[]> GetLifetimesAsync(string personID)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Lifetime
            {
                Birth = new DateTime(1995, 1, 1),
                Death = new DateTime(1995, 1, 1),
                Name = personID
            }).ToArray()) ;
        }
    }
}
