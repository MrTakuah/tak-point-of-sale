namespace takpos
{
    public partial class Product
    {
        string description { get; set; }
        string size { get; set; }

        public Product()
        {
            {
                if (description == null)
                {
                    description = "";
                }
                if (size == null)
                {
                    size = "";
                }
            }
        }
    };

}