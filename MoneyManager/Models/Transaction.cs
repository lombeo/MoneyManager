using System;
using System.Collections.Generic;

namespace MoneyManager.Models
{
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public int? AccountId { get; set; }
        public int? WalletId { get; set; }
        public int? CategoryId { get; set; }
        public int? Scid { get; set; }
        public int? BudgetId { get; set; }
        public decimal? Opening { get; set; }
        public decimal? Ending { get; set; }
        public decimal? Balance { get; set; }
        public DateTime? TransDate { get; set; }
        public string? Note { get; set; }

        public virtual Account? Account { get; set; }
        public virtual Budget? Budget { get; set; }
        public virtual Category? Category { get; set; }
        public virtual SubCategory? Sc { get; set; }
        public virtual Wallet? Wallet { get; set; }

        public Transaction(int? accountId, int? walletId, int? categoryId, int? scid, int? budgetId, decimal? opening, decimal? ending, decimal? balance, DateTime? transDate, string? note)
        {
            AccountId = accountId;
            WalletId = walletId;
            CategoryId = categoryId;
            Scid = scid;
            BudgetId = budgetId;
            Opening = opening;
            Ending = ending;
            Balance = balance;
            TransDate = transDate;
            Note = note;
        }
    }
}
