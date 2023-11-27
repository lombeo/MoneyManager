using System;
using System.Collections.Generic;

namespace MoneyManager.Models
{
    public partial class Wallet
    {
        public Wallet()
        {
            Budgets = new HashSet<Budget>();
            Transactions = new HashSet<Transaction>();
        }

        public int WalletId { get; set; }
        public int? AccountId { get; set; }
        public string? WalletName { get; set; }
        public decimal? Balance { get; set; }

        public virtual Account? Account { get; set; }
        public virtual ICollection<Budget> Budgets { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
