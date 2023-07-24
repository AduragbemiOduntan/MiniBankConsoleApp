namespace MiniBankConsoleApp.Entites
{
    public class Transaction
    {
        public  string TransactionId { get; set; }
        public string TranscationType { get; set; }
        public string TransactionAmount { get; set; }
        public string SourceAccount { get; set; }
        public string DestinationAccount { get; set; }

/*        public Customer Customer { get; set; }
        public BankAccount Account { get; set; }*/
    }
}
