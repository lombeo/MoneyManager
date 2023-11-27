using System;
using System.Collections.Generic;

namespace MoneyManager.Models
{
    public partial class Account
    {
        public Account()
        {
            Budgets = new HashSet<Budget>();
            Transactions = new HashSet<Transaction>();
            Wallets = new HashSet<Wallet>();
        }

        public int AccountId { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public virtual ICollection<Budget> Budgets { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<Wallet> Wallets { get; set; }
    }
}
