namespace MiniBankConsoleApp.Entites
{
    public class BankAccount : Customer
    {
        public string AccountType { get; set; }
        public string AccountNumber { get; set; }
        public double AccountBalance { get; } = 0;
       /* public string AccountStatus { get; set; }*/
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
     

        /*public Customer Customer { get; set; }
        public ICollection<Transaction> Transaction { get; set; }*/
    }
}
