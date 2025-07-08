using Microsoft.EntityFrameworkCore;
using PatientManagement.Models;
using System.Collections.Generic;

namespace PatientManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Medicine> Medicines { get; set; }

    }
}
