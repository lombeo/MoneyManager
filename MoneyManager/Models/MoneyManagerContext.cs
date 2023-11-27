using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace MoneyManager.Models
{
    public partial class MoneyManagerContext : DbContext
    {
        public MoneyManagerContext()
        {
        }

        public MoneyManagerContext(DbContextOptions<MoneyManagerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Budget> Budgets { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<SubCategory> SubCategories { get; set; } = null!;
        public virtual DbSet<Transaction> Transactions { get; set; } = null!;
        public virtual DbSet<Wallet> Wallets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyCnn"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.Password).HasMaxLength(150);
            });

            modelBuilder.Entity<Budget>(entity =>
            {
                entity.ToTable("Budget");

                entity.Property(e => e.BudgetId).HasColumnName("BudgetID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BudgetName).HasMaxLength(150);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.From).HasColumnType("date");

                entity.Property(e => e.Scid).HasColumnName("SCID");

                entity.Property(e => e.To).HasColumnType("date");

                entity.Property(e => e.WalletId).HasColumnName("WalletID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Budgets)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK__Budget__AccountI__412EB0B6");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Budgets)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Budget__Category__4222D4EF");

                entity.HasOne(d => d.Sc)
                    .WithMany(p => p.Budgets)
                    .HasForeignKey(d => d.Scid)
                    .HasConstraintName("FK__Budget__SCID__4316F928");

                entity.HasOne(d => d.Wallet)
                    .WithMany(p => p.Budgets)
                    .HasForeignKey(d => d.WalletId)
                    .HasConstraintName("FK__Budget__WalletID__440B1D61");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(150);
            });

            modelBuilder.Entity<SubCategory>(entity =>
            {
                entity.HasKey(e => e.Scid)
                    .HasName("PK__SubCateg__F7FE93ACEAC2CF36");

                entity.ToTable("SubCategory");

                entity.Property(e => e.Scid).HasColumnName("SCID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Scname)
                    .HasMaxLength(150)
                    .HasColumnName("SCName");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SubCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__SubCatego__Categ__3E52440B");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("Transaction");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.BudgetId).HasColumnName("BudgetID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Ending).HasColumnType("money");

                entity.Property(e => e.Opening).HasColumnType("money");

                entity.Property(e => e.Scid).HasColumnName("SCID");

                entity.Property(e => e.TransDate).HasColumnType("datetime");

                entity.Property(e => e.WalletId).HasColumnName("WalletID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK__Transacti__Accou__46E78A0C");

                entity.HasOne(d => d.Budget)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.BudgetId)
                    .HasConstraintName("FK__Transacti__Budge__4AB81AF0");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Transacti__Categ__48CFD27E");

                entity.HasOne(d => d.Sc)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.Scid)
                    .HasConstraintName("FK__Transactio__SCID__49C3F6B7");

                entity.HasOne(d => d.Wallet)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.WalletId)
                    .HasConstraintName("FK__Transacti__Walle__47DBAE45");
            });

            modelBuilder.Entity<Wallet>(entity =>
            {
                entity.ToTable("Wallet");

                entity.Property(e => e.WalletId).HasColumnName("WalletID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.WalletName).HasMaxLength(150);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Wallets)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK__Wallet__AccountI__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
