
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
