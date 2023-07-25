using MiniBankConsoleApp.Entites;

namespace MiniBankConsoleApp.Logic
{
    public class CreditTransactionLogic
    {
        BankAccount account = new BankAccount();
        Transaction transaction = new Transaction();

        List<BankAccount> accounts = new List<BankAccount>();
        List<Transaction> transactions = new List<Transaction>();

        public string DepositFund()
        {
            Console.WriteLine("Enter the amount you want to deposit");
            bool isAmount = double.TryParse(Console.ReadLine(), out double amount);
            Console.WriteLine("Enter the account number");
            string acctNumber = Console.ReadLine();
            if (!(acctNumber == account.AccountNumber))
            {
                return ("Invalid account number");
            }
            account.AccountBalance += amount;

            transaction.TransactionId = Guid.NewGuid().ToString();
            transaction.TransactionStatus = "Successful";
            transaction.TranscationType = "Deposit";
            transaction.TransactionAmount = amount;
            transaction.SourceAccount = account.AccountNumber;
            transaction.DestinationBank = null;
            transaction.DestinationAccount = null;
            transaction.TransactionDescription = null;
            transaction.Balance = account.AccountBalance;

            transactions.Add(transaction);
            accounts.Add(account);

            foreach (var singleTrans in transactions)
            {
                Console.WriteLine(singleTrans);
            }
            foreach (var singleAccount in accounts)
            {
                Console.WriteLine(singleAccount);
            }
            Console.WriteLine("Transaction successful!");
            return
                ($"TransactionType: {transaction.TranscationType}, TransacttionAmount: {transaction.TransactionAmount}, SourceAccount: {transaction.SourceAccount}, DestinationBank: {transaction.DestinationBank}, DestinationAccount: {transaction.DestinationAccount}, TransactionDescription: {transaction.TransactionDescription} TransactionStatus: {transaction.TransactionStatus}, AccountBalance: {transaction.Balance}");
        }
    }
}
