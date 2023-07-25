using MiniBankConsoleApp.Logic;

namespace MiniBankConsoleApp.Test
{
    [TestClass]
    public class AccountCreationTest
    {
        [TestMethod]
        public void TCreateAccountTest()
        {
            AccountCreationLogic accountCreation = new();
            string acctCreated = accountCreation.CreateAccount();
            Assert.AreEqual("", acctCreated);
        }
    }
}