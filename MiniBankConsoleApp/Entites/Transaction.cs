namespace MiniBankConsoleApp.Entites
{
    public class Transaction
    {
        public  string TransactionId { get; set; }
        public string TranscationType { get; set; }
        public double TransactionAmount { get; set; }
        public string SourceAccount { get; set; }
        public string DestinationBank { get; set; }
        public string DestinationAccount { get; set; }
        public string TransactionDescription { get; set; }
        public double Balance { get; set; }
        public string TransactionStatus { get; set; }

/*        public Customer Customer { get; set; }
        public BankAccount Account { get; set; }*/
    }
}
