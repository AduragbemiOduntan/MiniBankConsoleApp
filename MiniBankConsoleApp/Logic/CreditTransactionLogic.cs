namespace MiniBankConsoleApp.Logic
{
    public class CreditTransactionLogic
    {
        string bank = "";
        public void DepositFund()
        {
            Console.WriteLine("Enter the amount you want to deposit");
            bool isAmount = double.TryParse(Console.ReadLine(), out double amount);
            Console.WriteLine("Enter the account number you want to transfer to");
            string acctNumber = Console.ReadLine();
            Console.WriteLine("Choose Bank:\n1. Zenith\n2. Access,\n3. Polaris\n4. UBA\n5. Stanbic\n6. GTB");
            bool bankTrue = byte.TryParse(Console.ReadLine(), out byte bankOption);
            Console.WriteLine("Enter description");
            string transDescription = Console.ReadLine();
            Console.WriteLine("Enter pin");
            string pin = Console.ReadLine();

            if (!bankTrue)
            {
                Console.WriteLine("Input doesn't match options, try again");
            }
            switch (bankOption)
            {
                case 1:
                    bank = "Zenith";
                    break;
                case 2:
                    bank = "Access";
                    break;
                case 3:
                    bank = "Polaris";
                    break;
                case 4:
                    bank = "UBA";
                    break;
                case 5:
                    bank = "Stambic";
                    break;
                case 6:
                    bank = "GTB";
                    break;
            }
        }



    }
}
