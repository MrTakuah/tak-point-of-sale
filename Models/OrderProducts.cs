namespace tak_point_of_sale
{
    public partial class OrderProducts
    {
        Guid OrderProductId { get; set; }
        Guid OrderId { get; set; }
        string ProductDescription { get; set; }
        int Quantity { get; set; }
        string Size { get; set; }
        decimal Price { get; set; }
        DateTime BusinessDate { get; set; }
        DateTime CreatedAt { get; set; }

        public OrderProducts()
        {
            if (ProductDescription == null)
            {
                ProductDescription = "";
            }
            if (Size == null)
            {
                Size = "";
            }
        }
    };
}

