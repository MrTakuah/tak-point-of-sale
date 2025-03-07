namespace tak_point_of_sale

{
    public partial class OrderPerson
    {
        Guid OrderPersonId { get; set; }
        Guid OrderId { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        string Sms { get; set; }

        public OrderPerson()
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
    }
}