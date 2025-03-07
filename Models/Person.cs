namespace tak_point_of_sale
{
    public partial class Person
    {
        string Name { get; set; }
        string Email { get; set; }
        string Sms { get; set; }
        Guid PersonId { get; set; }
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