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
    public class BookingResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string BookingReference { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal DepositRequired { get; set; }
    }
}
