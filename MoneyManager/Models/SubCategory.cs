using System;
using System.Collections.Generic;

namespace MoneyManager.Models
{
    public partial class SubCategory
    {
        public SubCategory()
        {
            Budgets = new HashSet<Budget>();
            Transactions = new HashSet<Transaction>();
        }

        public int Scid { get; set; }
        public string? Scname { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<Budget> Budgets { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }

        public SubCategory(string? scname, int? categoryId)
        {
            Scname = scname;
            CategoryId = categoryId;
        }
    }
}
