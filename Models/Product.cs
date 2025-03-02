namespace takpos
{
    public partial class Product
    {
        string Description { get; set; }
        string Size { get; set; }
        decimal Price { get; set; }

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
            }
        }
    };

}