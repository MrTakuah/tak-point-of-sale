namespace takpos
{
    public partial class PersonOrder
    {
        string orderId2 { get; set; }
        Guid orderId3 { get; set; }
        string personName { get; set; }

        public PersonOrder()
        {
            if (orderId2 == null)
            {
                orderId2 = "";
            }
            if (personName == null)
            {
                personName = "";
            }

        }

    }

}