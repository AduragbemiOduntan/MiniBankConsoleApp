using MiniBankConsoleApp.Entites;
using System.Net.Mail;

namespace MiniBankConsoleApp.Logic
{
    public class AccountCreationLogic
    {
        /*  public Account _account; Customer _customer;*/
        /*  public static*/
        BankAccount account = new BankAccount();

        public string CreateAccount()
        {
            /*double acctBalance = 0;*/
            string acctType1 = "Savings";
            string acctType2 = "Current";
        AcctTypeOption: Console.WriteLine("Choose the account type you want to open\n1. Savings\n2. Current");
            bool acctOptionTrue = byte.TryParse(Console.ReadLine(), out byte acctType);
            if (!acctOptionTrue)
            {
                Console.WriteLine("Invalid option, try again.");
                goto AcctTypeOption;
            }
            switch (acctType)
            {
                case 1:
                case 2:
                    string accountType;
                    if (acctType == 1)
                    {
                        accountType = acctType1;
                    }
                    else
                    {
                        accountType = acctType2;
                    }
                Details: Console.WriteLine("Enter your first name.");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Enter your last name.");
                    string lastName = Console.ReadLine();
                EnterEmail: Console.WriteLine("Enter your email.");
                    string email = Console.ReadLine();
                    IsValidEmail(email);
                    if (!IsValidEmail(email))
                    {
                        Console.WriteLine("Invalid email. Try again");
                        goto EnterEmail;
                    }
                    Console.WriteLine("Enter your phone number.");
                    string phoneNumber = Console.ReadLine();
                    Console.WriteLine("Enter pin");
                    string pin = Console.ReadLine();

                    int lowerRange = 1234567890;
                    int upperRange = 2145678910;
                    var randomNum = new Random();
                    int getAccount = randomNum.Next(lowerRange, upperRange);
                    string acctNum = getAccount.ToString();

                    account.FirstName = firstName;
                    account.LastName = lastName;
                    account.Email = email;
                    account.PhoneNumber = phoneNumber;
                    account.AccountType = accountType;
                    account.Pin = pin;


                CorrectnessOption: Console.WriteLine("Please confirm your deatails");
                    Console.WriteLine
                        ($" Name: {account.FirstName} {account.LastName}\nEmail: {account.Email}\nPhone Number: {account.PhoneNumber}");
                    Console.WriteLine("Enter 1. Correct 2. Incorrect");
                    bool isCorrect = byte.TryParse(Console.ReadLine(), out byte option);
                    /* Account type: { account.FirstNme}*/
                    if (!isCorrect)
                    {
                        Console.WriteLine("Invalid option, try again.");
                        goto CorrectnessOption;
                    }

                    switch (option)
                    {
                        case 1:
                            Console.WriteLine($"Successful!\n Your {account.AccountType} account number is {acctNum}");
                            break;
                        case 2:
                            Console.WriteLine("Please re-enter your correct details");
                            goto Details;
                        default:
                            Console.WriteLine("Ivalid input, try again.");
                            goto CorrectnessOption;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option, try again.");
                    goto AcctTypeOption;
            }
            return ($" Name: {account.FirstName} {account.LastName}, Email: {account.Email}, PhoneNumber: {account.PhoneNumber}, AccountType: {account.AccountType}, AccountBalance: {account.AccountBalance}");
        }

        /*        public void StoreData()
                {
                    //Context

                }*/

        public void SignUp()
        {
            Console.WriteLine("Enter your email.");
            string email = Console.ReadLine();
        EnterPassword: Console.WriteLine("Enter your password.");
            string password = Console.ReadLine();
            Console.WriteLine("Confirm your password.");
            string password2 = Console.ReadLine();

            if (!(password == password2))
            {
                Console.WriteLine("Your password doesn't match. Re-enter password");
                goto EnterPassword;
            }
            Console.WriteLine("Sogn up successful! Proceed to other transcation.");
        }


        bool IsValidEmail(string mail)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(mail);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
