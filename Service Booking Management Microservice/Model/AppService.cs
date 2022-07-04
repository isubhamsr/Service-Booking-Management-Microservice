namespace Service_Booking_Management_Microservice.Model
{
    public class AppService
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public DateTime ReqDate { get; set; }
        public string Problem { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
