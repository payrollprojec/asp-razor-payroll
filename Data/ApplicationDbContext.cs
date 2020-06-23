using System;
using System.Collections.Generic;
using System.Linq;
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
        public DbSet<PayrollAppRazorPages.Models.Holiday> Holiday { get; set; }
        public DbSet<PayrollAppRazorPages.Models.GlobalSettings> GlobalSettings { get; set; }


        internal Task UpdateAsync(StaffSalary staffSalary)
        {
            throw new NotImplementedException();
        }

        public int WeekDaysInMonth(int year, int month)
        {
            GlobalSettings g = GlobalSettings.SingleOrDefault();
            if (!string.IsNullOrEmpty(g.NoWorkDays))
            {
                string[] noWorkDaysString = g.NoWorkDays.Split(",");
                List<int> noWorkDays = new List<int>();
                for (int i = 0; i < noWorkDaysString.Length; i++)
                {
                    noWorkDays.Add(int.Parse(noWorkDaysString[i]));
                }
                int days = DateTime.DaysInMonth(year, month);
                List<DateTime> dates = new List<DateTime>();
                for (int i = 1; i <= days; i++)
                {
                    dates.Add(new DateTime(year, month, i));
                }

                int weekDays = dates.Where(d => !noWorkDays.Contains((int)d.DayOfWeek)).Count();
                List<Holiday> Holidays = Holiday.Where(h => h.HolidayDate.Value.Year == year && h.HolidayDate.Value.Month == month).ToList();
                foreach (Holiday h in Holidays)
                {
                    if (noWorkDays.Contains((int) ((DateTime)h.HolidayDate).DayOfWeek))
                    {
                        continue;
                    }
                    weekDays -= 1;
                }
                return weekDays;
            }
            // if NoWorkDay empty, return count of all dates
            else
            {
                int days = DateTime.DaysInMonth(year, month);
                List<DateTime> dates = new List<DateTime>();
                for (int i = 1; i <= days; i++)
                {
                    dates.Add(new DateTime(year, month, i));
                }

                int weekDays = dates.Count();
                List<Holiday> Holidays = Holiday.Where(h => h.HolidayDate.Value.Year == year && h.HolidayDate.Value.Month == month).ToList();

                weekDays -= Holidays.Count();

                return weekDays;
            }   
        }
    }
}
