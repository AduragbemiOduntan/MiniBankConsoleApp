namespace MiniBankConsoleApp.Logic
{
    public class DebitTransactionLogic
    {
        

        public void WithdrawFund()
        {
            Console.WriteLine("Enter amount");
            bool isAmount = double.TryParse(Console.ReadLine(), out double amount);
            Console.WriteLine("Enter pin");
            string pin = Console.ReadLine();


        }

        public void TransferFund()
        {
            Console.WriteLine("Enter amount");
            bool isAmount = double.TryParse(Console.ReadLine(), out double amount);
            Console.WriteLine("Enter the account number you want to transfer to");
            string acctNumber = Console.ReadLine();
            Console.WriteLine("Choose Bank:\n1. Zenith\n2. Access,\n3. Polaris\n4. UBA\n5. Stanbic\n6. GTB");
            bool bankTrue = byte.TryParse(Console.ReadLine(), out byte bankOption);
            Console.WriteLine("Enter description");
            string transDescription = Console.ReadLine();
            Console.WriteLine("Enter pin");
            string pin = Console.ReadLine();
        }
    }
}
