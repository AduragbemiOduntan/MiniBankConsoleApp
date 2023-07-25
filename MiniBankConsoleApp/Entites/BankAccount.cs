namespace MiniBankConsoleApp.Entites
{
    public class BankAccount : Customer
    {
        public string AccountType { get; set; }
        public string AccountNumber { get; set; }
        public double AccountBalance { get; set; } = 0;
       /* public string AccountStatus { get; set; }*/
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    /*    public string CreatedBy { get; set; }*/
     

        /*public Customer Customer { get; set; }
        public ICollection<Transaction> Transaction { get; set; }*/
    }
}
