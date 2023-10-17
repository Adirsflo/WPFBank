namespace WPFBank.Interface
{
    class SavingsAccount : IAccount
    {
        public double SavingsBalance { get; set; } = 1000;
        public void TransferMoney()
        {

        }
    }
}
