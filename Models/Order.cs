namespace tak_point_of_sale
{
    public partial class Order
    {
        public Guid OrderId { get; set; }
        public DateTime BusinessDate { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public Order()
        {
            if (Status == null)
            {
                Status = "";
            }
            
        }

    }

}