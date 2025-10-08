using Phumla_Kamnandi_GRP_12.Business.Entities;
using Phumla_Kamnandi_GRP_12.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_GRP_12.Database
{
    public class MockGuestRepository : GuestRepositoryInterface
    {
        private static List<Guest> _guests = new List<Guest>();

        public Guest GetById(string guestId)
        {
            return _guests.FirstOrDefault(g => g.GuestId == guestId);
        }

        public Guest GetByEmail(string email)
        {
            return _guests.FirstOrDefault(g =>
                g.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        public Guest GetByPhone(string phone)
        {
            return _guests.FirstOrDefault(g => g.Phone == phone);
        }

        public List<Guest> GetAll()
        {
            return _guests.ToList();
        }

        public void Add(Guest guest)
        {
            _guests.Add(guest);
        }

        public void Update(Guest guest)
        {
            var existing = GetById(guest.GuestId);
            if (existing != null)
            {
                _guests.Remove(existing);
                _guests.Add(guest);
            }
        }

        public bool Exists(string guestId)
        {
            return _guests.Any(g => g.GuestId == guestId);
        }
    }
}
