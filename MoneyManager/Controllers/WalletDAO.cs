using Microsoft.EntityFrameworkCore;
using MoneyManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Controllers
{
    internal class WalletDAO
    {


        public void AddWallet(int accountID, string walletName, decimal balance)
        {
            MoneyManagerContext context = new MoneyManagerContext();
            var wallet = new Wallet
            {
                AccountId = accountID,
                WalletName = walletName,
                Balance = balance
            };

            context.Wallets.Add(wallet);
            context.SaveChanges();

            MessageBox.Show("Thêm ví thành công!");
        }

        public Wallet GetWallet(int accountID)
        {
            MoneyManagerContext context = new MoneyManagerContext();
            return context.Wallets.FirstOrDefault(w => w.AccountId == accountID);
        }

        public Wallet GetWalletById(int walletID)
        {
            MoneyManagerContext context = new MoneyManagerContext();
            Wallet updateW = context.Wallets.FirstOrDefault(w => w.WalletId == walletID);
            return updateW;
        }

        public void DeleteWallet(int walletID)
        {
            MoneyManagerContext context = new MoneyManagerContext();
            var wallet = context.Wallets.FirstOrDefault(w => w.WalletId == walletID);

            if (wallet != null)
            {
                context.Wallets.Remove(wallet);
                context.SaveChanges();
                Console.WriteLine("Wallet deleted successfully.");
            }
            else
            {
                Console.WriteLine("Wallet not found.");
            }
        }

        public decimal? GetBalance(int accountID)
        {
            MoneyManagerContext context = new MoneyManagerContext();
            decimal? totalBalance = context.Wallets
                .Where(w => w.AccountId == accountID)
                .Sum(w => w.Balance);

            return totalBalance;
        }

        public List<Transaction> GetTransactionsBeforeCurrentMonth(int accountID, int walletID)
        {
            MoneyManagerContext context = new MoneyManagerContext();
            DateTime currentMonth = DateTime.Now;
            DateTime currentMonthStart = new DateTime(currentMonth.Year, currentMonth.Month, 1);

            List<Transaction> transactions = context.Transactions
                .Where(t => t.AccountId == accountID && t.WalletId == walletID && t.TransDate < currentMonthStart)
                .ToList();

            return transactions;
        }


        public List<Transaction> GetTransactionsInCurrentMonth(int accountID, int walletID)
        {
            MoneyManagerContext context = new MoneyManagerContext();
            DateTime currentMonth = DateTime.Now;
            DateTime currentMonthStart = new DateTime(currentMonth.Year, currentMonth.Month, 1);

            List<Transaction> transactions = context.Transactions
                .Where(t => t.AccountId == accountID && t.WalletId == walletID && t.TransDate >= currentMonthStart && t.TransDate <= currentMonth)
                .OrderBy(t => t.TransDate)
                .ToList();

            return transactions;
        }

        public List<Transaction> GetTransactionsInFuture(int accountID, int walletID)
        {
            MoneyManagerContext context = new MoneyManagerContext();
            DateTime currentMonth = DateTime.Now;

            List<Transaction> transactions = context.Transactions
                .Where(t => t.AccountId == accountID && t.WalletId == walletID && t.TransDate > currentMonth)
                .ToList();

            return transactions;
        }

        public Budget GetBudgetByBudID(int? budID)
        {
            MoneyManagerContext context = new MoneyManagerContext();
            return context.Budgets.FirstOrDefault(b => b.BudgetId == budID);
        }

        public List<Transaction> getTransactionsByDate(int accountID, DateTime date, Wallet wallet)
        {
            MoneyManagerContext context = new MoneyManagerContext();
            DateTime startDate = date.Date;
            DateTime endDate = startDate.AddDays(1);

            List<Transaction> transactions = context.Transactions
                .Where(t => t.AccountId == accountID && t.WalletId == wallet.WalletId && t.TransDate >= startDate && t.TransDate < endDate)
                .ToList();

            return transactions;
        }



        public string getSCNameByID(int? SCID)
        {
            MoneyManagerContext context = new MoneyManagerContext();
            if (SCID == null)
            {
                return string.Empty;
            }

            var subCategory = context.SubCategories.FirstOrDefault(sc => sc.Scid == SCID);

            if (subCategory != null)
            {
                return subCategory.Scname;
            }

            return string.Empty;
        }

        public void deleteTransaction(int transID)
        {
            MoneyManagerContext context = new MoneyManagerContext();
            var transactionsToDelete = context.Transactions.FirstOrDefault(t => t.TransactionId == transID);

            if (transactionsToDelete != null)
            {
                Wallet wallet = context.Wallets.FirstOrDefault(w => w.WalletId == transactionsToDelete.WalletId);
                if (transactionsToDelete.CategoryId == 1)
                {
                    wallet.Balance += transactionsToDelete.Balance;
                }
                else if (transactionsToDelete.CategoryId == 2)
                {
                    wallet.Balance -= transactionsToDelete.Balance;
                }
                Home homeForm = Application.OpenForms.OfType<Home>().FirstOrDefault();
                if (homeForm != null)
                {
                    homeForm.UpdateUI(wallet);
                }
            }
            context.Transactions.RemoveRange(transactionsToDelete);
            context.SaveChanges();
        }

        public List<Budget> GetBudgetsByAccId(int accId, int walId)
        {
            using (var context = new MoneyManagerContext())
            {
                DateTime today = DateTime.Today;

                return context.Budgets
                    .Where(b => b.AccountId == accId && b.WalletId == walId && b.To >= today)
                    .ToList();
            }
        }

        public List<Budget> GetFinishBudgetsByAccId(int accId, int walId)
        {
            using (var context = new MoneyManagerContext())
            {
                DateTime today = DateTime.Today;

                return context.Budgets
                    .Where(b => b.AccountId == accId && b.WalletId == walId && b.To <= today)
                    .ToList();
            }
        }


        public decimal? GetRemainingBudgetAmount(int budgetId)
        {
            using (var dbContext = new MoneyManagerContext())
            {
                var budget = dbContext.Budgets.FirstOrDefault(b => b.BudgetId == budgetId);
                if (budget != null)
                {
                    var totalTransactionBalance = dbContext.Transactions
                        .Where(t => t.BudgetId == budgetId)
                        .Sum(t => t.Balance);

                    return budget.Amount - totalTransactionBalance;
                }
                else
                {
                    throw new Exception("Không tìm thấy Budget với BudgetID đã cho.");
                }
            }
        }

        public decimal? GetTotalTransactionBalance(int budgetId)
        {
            using (var dbContext = new MoneyManagerContext())
            {
                var budget = dbContext.Budgets.FirstOrDefault(b => b.BudgetId == budgetId);
                if (budget != null)
                {
                    var totalTransactionBalance = dbContext.Transactions
                        .Where(t => t.BudgetId == budgetId)
                        .Sum(t => t.Balance);

                    return totalTransactionBalance;
                }
                else
                {
                    throw new Exception("Không tìm thấy Budget với BudgetID đã cho.");
                }
            }
        }

        public void deleteBudgetByBudgetId(int bid)
        {
            MoneyManagerContext context = new MoneyManagerContext();
            var budgetToDelete = context.Budgets.FirstOrDefault(b => b.BudgetId == bid);
            Home homeForm = Application.OpenForms.OfType<Home>().FirstOrDefault();
            if (homeForm != null)
            {
                homeForm.btnBudget_Click(new object(), new EventArgs());
            }
            context.Budgets.RemoveRange(budgetToDelete);
            context.SaveChanges();
        }

    }
}
