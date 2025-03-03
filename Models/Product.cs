namespace takpos
{
    public partial class Product
    {
        Guid ProductId { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
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
                if (Size == null)
                {
                    Size = "";
                }
                if (ProductLabel == null)
                {
                    ProductLabel = "";
                }
            }
        }
    };

}