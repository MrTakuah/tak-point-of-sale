namespace tak_point_of_sale
{
    public partial class Product
    {
        public Guid ProductId { get; set; }
        public string Description { get; set; }
        // public string Size { get; set; }
        public decimal Price { get; set; }
        public string ProductLabel { get; set; }
        public DateTime CreatedAt { get; set; }

        public Product()
        {
            {
                if (Description == null)
                {
                    Description = "";
                }
                if (ProductLabel == null)
                {
                    ProductLabel = "";
                }
            }
        }
    };

}