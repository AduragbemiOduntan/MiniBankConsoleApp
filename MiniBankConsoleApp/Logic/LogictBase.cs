using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBankConsoleApp.Logic
{
    public class LogicBase
    {
        public static void TransactionPrompt()
        {
            Console.WriteLine("Welcome to Hebron Bank, we are pleased to serve you.\nWhere will like to start?");
            Console.WriteLine("1. Open New Account.\n2. Cash Deposit.\n3. Cash Withdrawal.\n4. Cash Transfer.\n0. To Exit.");
            bool transResponseIsTrue = byte.TryParse(Console.ReadLine(), out byte transResponse);

            if (transResponseIsTrue)
            {
                switch (transResponse)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 0:
                        break;

                }
            }

        }


    }
    
}
