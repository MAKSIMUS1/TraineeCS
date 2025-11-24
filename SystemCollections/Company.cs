using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemCollections
{
    public class Company
    {
        public int Account { get; set; }
        public int Balance { get; set; }
        public Company(int account, int balance)
        {
            Account = account;
            Balance = balance;
        }
    }
}
