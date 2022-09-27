using System;
using System.Threading.Tasks;
using MedicalClinic.Domain.Invoice.Entities;
using MedicalClinic.Domain.Invoice.Interfaces;
using MedicalClinic.Domain.Invoice.Interfaces.Persistence;
using Microsoft.EntityFrameworkCore;


namespace MedicalClinic.Persistence.Invoice.Contexts
{

    /// <summary>
    /// Invoice Context Database
    /// </summary>
    public class InvoiceContext: DbContext
    {
        /// <summary>
        /// Configuration
        /// </summary>
        /// <param name="optionsBuilder">Option to connection</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           => optionsBuilder.UseSqlServer(Spin.Helper.Configuration.Configuration.GetConnectionString("Spin").ConnectionString);

        /// <summary>
        /// Account Header
        /// </summary>
        public DbSet<AccountHeader> AccountHeader { get; set; }
        /// <summary>
        /// Account Detail
        /// </summary>
        public DbSet<AccountDetail> AccountDetail { get; set; }

    }
}
