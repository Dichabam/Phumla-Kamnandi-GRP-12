/*Semester Project - Group 12
 * 
 * -----------------Members--------------------------
 * Dichaba Mofokeng, MFKDIC001
 * Simon Baraka, LMDSIM001 
 * Rearabilwe Kgokong, ,KGKREA001  
 * Khumiso Motata, MTTKAG001 
 */
using Phumla_Kamnandi_GRP_12.Business.Entities;
using System.Collections.Generic;

namespace Phumla_Kamnandi_GRP_12.Business.Interfaces
{
    public interface GuestRepositoryInterface
    {
        Guest GetById(string guestId);
        Guest GetByEmail(string email);
        Guest GetByPhone(string phone);
        List<Guest> GetAll();
        void Add(Guest guest);
        void Update(Guest guest);
        bool Exists(string guestId);
    }
}