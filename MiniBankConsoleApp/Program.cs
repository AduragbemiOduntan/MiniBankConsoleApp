using MiniBankConsoleApp.Logic;


/*int lowerRange = 1234567890;
int upperRange = 2145678910;
var randomNum = new Random();
int accountNum = randomNum.Next(lowerRange, upperRange);
Console.WriteLine(accountNum.ToString());*/

/*AccountCreationLogic acctLogic = new();
Console.WriteLine(acctLogic.CreateAccount());*/

AccountCreationLogic acctCreation = new AccountCreationLogic();

string userAcct = acctCreation.CreateAccount();

string directoryPath = "C:\\Users\\aduragbemi.oduntan\\Desktop\\JustProjects\\MiniBankConsoleApp\\MiniBankConsoleApp\\Data\\";
string filePath = Path.Combine(directoryPath, "Accounts.txt");

Directory.CreateDirectory(directoryPath);

using (StreamWriter sw = new StreamWriter(filePath))
{
    sw.WriteLine(userAcct);
    sw.Dispose();
}

