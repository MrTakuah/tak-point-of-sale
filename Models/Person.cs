namespace tak_point_of_sale
{
    public partial class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Sms { get; set; }
        public Guid PersonId { get; set; }
        public Person()
        {
            {
                if (Name == null)
                {
                    Name = "";
                }
                if (Email == null)
                {
                    Email = "";
                }
                if (Sms == null)
                {
                    Sms = "";
                }
            }
        }
    };
}