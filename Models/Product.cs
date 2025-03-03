namespace takpos
{
    public partial class Product
    {
        string Description { get; set; }
        string Size { get; set; }
        decimal Price { get; set; }
        string ProductLabel { get; set; }
        Guid ProductId {get; set; }

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