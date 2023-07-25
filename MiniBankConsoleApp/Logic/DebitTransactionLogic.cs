using MiniBankConsoleApp.Entites;

namespace MiniBankConsoleApp.Logic
{
    public class DebitTransactionLogic
    {
        BankAccount account = new BankAccount();
        Transaction transaction = new Transaction();

        List<BankAccount> accounts = new List<BankAccount>();
        List<Transaction> transactions = new List<Transaction>();
    

        string acctType1 = "Savings";
        string acctType2 = "Current";

        public string WithdrawFund()
        {
            /*double acctBal = account.AccountBalance;*/
            Console.WriteLine("Enter amount");
            bool isAmount = double.TryParse(Console.ReadLine(), out double amount);
        EnterPin: Console.WriteLine("Enter pin");
            string pin = Console.ReadLine();

            if (!(pin == account.Pin))
            {
                return ("Invalid user pin");
            }

            if (account.AccountType == acctType1)
            {
                account.AccountBalance -= amount;
                if (account.AccountBalance < 1000)
                {

                    transaction.TransactionStatus = "Failed";
                    return ("Inssuficient balance.");
                }
                transaction.TranscationType = acctType1;
            }
            else if (account.AccountType == acctType2)
            {
                account.AccountBalance -= amount;
                if (account.AccountBalance < 0)
                {
                    transaction.TransactionStatus = "Failed";
                    return ("Inssuficient balance.");
                }
            }
            transaction.TransactionId = Guid.NewGuid().ToString();
            transaction.TransactionStatus = "Successful";
            transaction.TranscationType = "Withdrawal";
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

            Console.WriteLine("Transaction successful, please take your cash.");
            return
                ($"TransactionType: {transaction.TranscationType}, TransacttionAmount: {transaction.TransactionAmount}, SourceAccount: {transaction.SourceAccount}, DestinationBank: {transaction.DestinationBank}, DestinationAccount: {transaction.DestinationAccount}, TransactionDescription: {transaction.TransactionDescription} TransactionStatus: {transaction.TransactionStatus}, AccountBalance: {transaction.Balance}");
        }

        public string TransferFund()
        {
            string destinationBank = "";
            Console.WriteLine("Enter amount");
            bool isAmount = double.TryParse(Console.ReadLine(), out double amount);
            Console.WriteLine("Enter the beneficiary account number");
            string beneficiaryAcctNumber = Console.ReadLine();
        ChooseBank: Console.WriteLine("Choose Bank:\n1. Zenith\n2. Access,\n3. Polaris\n4. UBA\n5. Stanbic\n6. GTB");
            bool bankTrue = byte.TryParse(Console.ReadLine(), out byte bankOption);
            if (!bankTrue)
            {
                Console.WriteLine("Invalid bank, choose a valid option");
                goto ChooseBank;
            }
            switch (bankOption)
            {
                case 1:
                    destinationBank = "Zenith";
                    break;
                case 2:
                    destinationBank = "Access";
                    break;
                case 3:
                    destinationBank = "Polaris";
                    break;
                case 4:
                    destinationBank = "UBA";
                    break;
                case 5:
                    destinationBank = "Stambic";
                    break;
                case 6:
                    destinationBank = "GTB";
                    break;
                default:
                    Console.WriteLine("Invalid option, try again.");
                    goto ChooseBank;
            }
            Console.WriteLine("Enter description");
            string transDescription = Console.ReadLine();
            Console.WriteLine("Enter pin");
            string pin = Console.ReadLine();
            if (!(pin == account.Pin))
            {
                return ("Invalid user pin");
            }
            if (account.AccountType == acctType1)
            {
                account.AccountBalance -= amount;
                if (account.AccountBalance < 1000)
                {

                    transaction.TransactionStatus = "Failed";
                    return ("Inssuficient balance.");
                }
                transaction.TranscationType = acctType1;
            }
            else if (account.AccountType == acctType2)
            {
                account.AccountBalance -= amount;
                if (account.AccountBalance < 0)
                {
                    transaction.TransactionStatus = "Failed";
                    return ("Inssuficient balance.");
                }
            }
            transaction.TransactionId = Guid.NewGuid().ToString();
            transaction.TransactionStatus = "Successful";
            transaction.TranscationType = "Transfer";
            transaction.TransactionAmount = amount;
            transaction.SourceAccount = account.AccountNumber;
            transaction.DestinationBank = destinationBank;
            transaction.DestinationAccount = beneficiaryAcctNumber;
            transaction.TransactionDescription = transDescription;
            transaction.Balance = account.AccountBalance;
            Console.WriteLine("Transaction successful!");
            return
                ($"TransactionType: {transaction.TranscationType}, TransacttionAmount: {transaction.TransactionAmount}, SourceAccount: {transaction.SourceAccount}, DestinationBank: {transaction.DestinationBank}, DestinationAccount: {transaction.DestinationAccount}, TransactionDescription: {transaction.TransactionDescription} TransactionStatus: {transaction.TransactionStatus}, AccountBalance: {transaction.Balance}");
        }
    }
}
