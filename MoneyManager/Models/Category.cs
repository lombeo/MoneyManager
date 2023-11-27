using System;
using System.Collections.Generic;

namespace MoneyManager.Models
{
    public partial class Category
    {
        public Category()
        {
            Budgets = new HashSet<Budget>();
            SubCategories = new HashSet<SubCategory>();
            Transactions = new HashSet<Transaction>();
        }

        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }

        public virtual ICollection<Budget> Budgets { get; set; }
        public virtual ICollection<SubCategory> SubCategories { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
