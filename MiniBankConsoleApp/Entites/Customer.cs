using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MiniBankConsoleApp.Entites
{
    public class Customer 
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Pin { get; set; }

        /*     public ICollection<BankAccount> Accounts { get; set; }
             public ICollection<Transaction> Transaction { get;}*/
    }
}
