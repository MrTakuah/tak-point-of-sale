namespace tak_point_of_sale
{
    public partial class OrderProducts
    {
        Guid OrderProductId { get; set; }
        Guid OrderId { get; set; }
        string ProductDescription { get; set; }
        string ProductSize { get; set; }
        decimal ProductPrice { get; set; }
        public OrderProducts()
        {
            if (ProductDescription == null)
            {
                ProductDescription = "";
            }
            if (ProductSize == null)
            {
                ProductSize = "";
            }
        }
    };
}

