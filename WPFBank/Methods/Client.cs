using WPFBank.Interface;

namespace WPFBank.Methods
{
    public class Client : User
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FullName { get { return FirstName + " " + LastName; } }
        public SalaryAccount SalaryAccount { get; set; } = new();
        public SavingsAccount SavingsAccount { get; set; } = new();

        public Client(string username, string password) : base(username, password)
        {
        }

        public string GetInfo()
        {
            return $"{FullName}";
        }
    }
}
