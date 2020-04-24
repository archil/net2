using FirstMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Services
{
    public interface IRsvpService
    {
        IEnumerable<Rsvp> GetRsvps();
        void Add(Rsvp model);
    }
}
