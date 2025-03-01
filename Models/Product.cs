namespace takpos
{
    public partial class Person
    {
        string name { get; set; }
        string email { get; set; }
        string sms { get; set; }

        public Person()
        {
            {
                if (name == null)
                {
                    name = "";
                }
                if (email == null)
                {
                    email = "";
                }
                if (sms == null)
                {
                    sms = "";
                }
            }
        }
    };

}