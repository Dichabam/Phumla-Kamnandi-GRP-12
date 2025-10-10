/*Semester Project - Group 12
 * 
 * -----------------Members--------------------------
 * Dichaba Mofokeng, MFKDIC001
 * Simon Baraka, LMDSIM001 
 * Rearabilwe Kgokong, ,KGKREA001  
 * Khumiso Motata, MTTKAG001 
 */
namespace Phumla_Kamnandi_GRP_12.Business.Entities
{
    public class Room
    {
        public int RoomNumber { get; private set; }
        public int MaxOccupancy { get; private set; }
        public bool IsAvailable { get; set; }

        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
            MaxOccupancy = 4; // Fixed 
            IsAvailable = true;
        }
    }
}