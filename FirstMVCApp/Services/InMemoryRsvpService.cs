using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstMVCApp.Models;

namespace FirstMVCApp.Services
{
    public class InMemoryRsvpService : IRsvpService
    {
        readonly List<Rsvp> rsvps = new List<Rsvp>();

        public InMemoryRsvpService()
        {
            rsvps.Add(new Rsvp { Namei = "archil", Email = "archil@wandio.com", Attending = true });
        }

        public void Add(Rsvp model)
        {
            rsvps.Add(model);
        }

        public IEnumerable<Rsvp> GetRsvps()
        {
            return rsvps;
        }
    }
}
