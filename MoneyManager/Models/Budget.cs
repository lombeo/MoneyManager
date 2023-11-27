using System;
using System.Collections.Generic;

namespace MoneyManager.Models
{
    public partial class Budget
    {
        public Budget()
        {
            Transactions = new HashSet<Transaction>();
        }

        public int BudgetId { get; set; }
        public int? AccountId { get; set; }
        public int? CategoryId { get; set; }
        public int? Scid { get; set; }
        public int? WalletId { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public decimal? Amount { get; set; }
        public string? Note { get; set; }
        public string? BudgetName { get; set; }

        public virtual Account? Account { get; set; }
        public virtual Category? Category { get; set; }
        public virtual SubCategory? Sc { get; set; }
        public virtual Wallet? Wallet { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }

        public Budget(int? accountId, int? categoryId, int? scid, int? walletId, DateTime? from, DateTime? to, decimal? amount, string? note, string? budgetName)
        {
            AccountId = accountId;
            CategoryId = categoryId;
            Scid = scid;
            WalletId = walletId;
            From = from;
            To = to;
            Amount = amount;
            Note = note;
            BudgetName = budgetName;
        }
    }
}
