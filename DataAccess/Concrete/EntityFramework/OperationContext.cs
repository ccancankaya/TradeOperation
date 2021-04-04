using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class OperationContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-N53STBC;Database=TradeManagement;Trusted_Connection=true");
        }

        public DbSet<Factory> Factories { get; set; }
        public DbSet<FactoryTransaction> FactoryTransactions { get; set; }
        public DbSet<PersonelExpense> PersonelExpenses { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<ProducerTransaction> ProducerTransactions { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
