using System;
using System.Threading.Tasks;
using MedicalClinic.Domain.Security.Entities;
using MedicalClinic.Domain.Security.Entities.Legacy;
using MedicalClinic.Domain.Security.Interfaces;
using MedicalClinic.Domain.Security.Interfaces.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MedicalClinic.Persistence.Security.Contexts
{
    /// <summary>
    /// User Context
    /// </summary>
    public class UserContext: DbContext
    {
        /// <summary>
        /// Configuration
        /// </summary>
        /// <param name="optionsBuilder">Option to connection</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           => optionsBuilder.UseNpgsql(Spin.Helper.Configuration.Configuration.GetConnectionString("Imhotep").ConnectionString);


        /// <summary>
        /// Users
        /// </summary>
        public DbSet<imhotep_usuarios> imhotep_usuarios { get; set; }

    }
}
