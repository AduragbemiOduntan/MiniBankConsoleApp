using MiniBankConsoleApp.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBankConsoleApp.Logic
{
    public class LogicBase
    {
        AccountCreationLogic createAcct = new AccountCreationLogic();
        DebitTransactionLogic debitTrans = new DebitTransactionLogic();
        CreditTransactionLogic creditTrans = new CreditTransactionLogic();
        string transactionData = "";
       
        
        public void TransactionPrompt()
        {
            do
            {
                Console.WriteLine("Welcome to Hebron Bank, we are pleased to serve you.\nWhere will like to start?");
            TransactionOption: Console.WriteLine("1. Open New Account.\n2. Cash Deposit.\n3. Cash Withdrawal.\n4. Cash Transfer.\n0. To Exit.");
                bool transResponseIsTrue = byte.TryParse(Console.ReadLine(), out byte transResponse);

                if (transResponseIsTrue)
                {
                    switch (transResponse)
                    {
                        case 1:
                            string userAcctData = createAcct.CreateAccount();
                            //Write into text file
                            string directoryPath = "C:\\Users\\aduragbemi.oduntan\\Desktop\\JustProjects\\MiniBankConsoleApp\\MiniBankConsoleApp\\Data\\";
                            string filePath = Path.Combine(directoryPath, "Accounts.txt");

                            Directory.CreateDirectory(directoryPath);

                            using (StreamWriter sw = new StreamWriter(filePath))
                            {
                                sw.WriteLine(userAcctData);
                                sw.Dispose();
                            }
                            break;
                        case 2:
                        case 3:
                        case 4:
                            if (transResponse == 2)
                            {
                                transactionData = creditTrans.DepositFund();
                            }
                            else if (transResponse == 3)
                            {
                                transactionData = debitTrans.WithdrawFund();
                            }
                            else if (transResponse == 4)
                            {
                                transactionData = debitTrans.WithdrawFund();
                            }
                            //Write into text file
                            debitTrans.TransferFund();
                            string directoryPath2 = "C:\\Users\\aduragbemi.oduntan\\Desktop\\JustProjects\\MiniBankConsoleApp\\MiniBankConsoleApp\\Data\\";
                            string filePath2 = Path.Combine(directoryPath2, "Transaction.txt");

                            Directory.CreateDirectory(directoryPath2);

                            using (StreamWriter sw = new StreamWriter(filePath2))
                            {
                                sw.WriteLine(transactionData);
                                sw.Dispose();
                            }
                            break;
                        case 0:
                            return;
                        default:
                            Console.WriteLine("Invalid Input");
                            goto TransactionOption;
                    }
                }
            }while(true);
        }
    }
}
