using Phumla_Kamnandi_GRP_12.Business.Entities;
using Phumla_Kamnandi_GRP_12.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_GRP_12.Business
{
    public class MockGuestRepository : GuestRepositoryInterface
    {
        private List<Guest> _guests = new List<Guest>();

        public MockGuestRepository()
        {
            // Pre-populate with test data
            _guests.Add(new Guest("John", "Smith", "john@email.com", "0211234567", "7 Main Rd, Rondebosch, 7700"));
            _guests.Add(new Guest("Nkosinathi", "Mthembu", "nkosi@email.com", "0311234567", "14 Lungelo Drive, Mtimkhulu, Durban, 4001"));
        }

        public void Add(Guest guest) => _guests.Add(guest);
        public void Update(Guest guest) { /* In real implementation would update */ }
        public Guest GetById(string guestId) => _guests.FirstOrDefault(g => g.GuestId == guestId);
        public Guest GetByEmail(string email) => _guests.FirstOrDefault(g => g.Email == email);
        public Guest GetByPhone(string phone) => _guests.FirstOrDefault(g => g.Phone == phone);
        public List<Guest> GetAll() => _guests;
        public bool Exists(string guestId) => _guests.Any(g => g.GuestId == guestId);
    }

}
