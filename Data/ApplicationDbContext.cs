using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PayrollAppRazorPages.Models;

namespace PayrollAppRazorPages.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<PayrollAppRazorPages.Models.StaffData> StaffData { get; set; }
        public DbSet<PayrollAppRazorPages.Models.Attendance> Attendance { get; set; }
        public DbSet<PayrollAppRazorPages.Models.AttendanceStatus> AttendanceStatus { get; set; }
        public DbSet<PayrollAppRazorPages.Models.StaffSalary> StaffSalary { get; set; }
        public DbSet<PayrollAppRazorPages.Models.SalaryItem> SalaryItem { get; set; }
        public DbSet<PayrollAppRazorPages.Models.StaffSalaryExtra> StaffSalaryExtra { get; set; }

        internal Task UpdateAsync(StaffSalary staffSalary)
        {
            throw new NotImplementedException();
        }
    }
}
