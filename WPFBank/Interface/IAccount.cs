namespace WPFBank.Interface
{
    public class Account
    {
        public decimal Balance { get; set; }
        public void TransferMoney(Account accountTransferingTo, decimal amount)
        {
            if (CheckBalance(amount))
            {
                accountTransferingTo.Balance += amount;

                this.Balance -= amount;
            }
        }

        private bool CheckBalance(decimal amount)
        {
            if (amount >= Balance)
            {
                return true;
            }
            return false;
        }
    }
}
