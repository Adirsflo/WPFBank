namespace WPFBank.Methods
{
    public class Client : User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }

        public Client(string username, string password) : base(username, password)
        {
        }
    }
}
