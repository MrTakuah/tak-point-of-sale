namespace takpos
{
    public partial class Order
    {
        Guid OrderId { get; set; }
        DateTime BusinessDate { get; set; }
        List<OrderProducts>? OrderProducts { get; set; }
        string Status { get; set; }

        public Order()
        {
            if (Status == null)
            {
                Status = "";
            }
            
        }

    }

}