using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PayrollAppRazorPages.Data;
using PayrollAppRazorPages.Models;

namespace PayrollAppRazorPages.Pages.Manage.Salaries
{
    [Authorize(Roles ="superadmin,admin")]
    public class CreateSalaryModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        [TempData]
        public string StatusMessage { get; set; }
        public CreateSalaryModel(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public string SelectedMonth { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SelectedYear { get; set; }
        public string SelectedDate { get; set; }
        public int WeekdaysCount { get; set; }
        [BindProperty]
        public int ExtraEarnCount { get; set; } // not used
        public List<Attendance> UserAttendance { get; set; }
        [BindProperty]
        public List<StaffSalaryExtra> StaffSalaryExtras{ get; set; }
        public IList<SelectListItem> ExtraEarnItems { get; set; }
        public IList<SelectListItem> ExtraDeductItems { get; set; }
        public List<SalaryItem> SalaryItem { get; set; }
        [BindProperty]
        public StaffSalary StaffSalary { get; set; }
        public StaffSalary AdvSalaryPur { get; set; }
        public ApplicationUser applicationUser { get; set; }
        [BindProperty]
        public List<string> EarnSelect { get; set; }
        [BindProperty]
        public List<string> DeductSelect { get; set; }
        private static int WeekDaysInMonth(int year, int month)
        {
            int days = DateTime.DaysInMonth(year, month);
            List<DateTime> dates = new List<DateTime>();
            for (int i = 1; i <= days; i++)
            {
                dates.Add(new DateTime(year, month, i));
            }

            int weekDays = dates.Where(d => d.DayOfWeek < DayOfWeek.Friday).Count();
            return weekDays;
        }
        public async Task<IActionResult> OnGetAsync(string Id)
        {
            //applicationUser = await _userManager.FindByIdAsync(Id);
            applicationUser = await _userManager.Users.Include(u => u.StaffData).Where(u => u.Id == Id).SingleOrDefaultAsync();

            if (applicationUser == null)
            {
                return NotFound();
            }
            bool isStaff = await _userManager.IsInRoleAsync(applicationUser, "staff");
            if (!isStaff)
            {
                return NotFound();
            }

            if (string.IsNullOrEmpty(SelectedYear) || string.IsNullOrEmpty(SelectedMonth))
            {
                SelectedMonth = DateTime.Now.Month.ToString();
                SelectedYear = DateTime.Now.Year.ToString();
            }
            SelectedDate = DateTime.Parse(SelectedYear + "-" + SelectedMonth + "-01").ToString("MMMM yyyy");
            // get working days of this month
            WeekdaysCount = WeekDaysInMonth(int.Parse(SelectedYear), int.Parse(SelectedMonth));
            // get attendance for this month
            UserAttendance = await _context.Attendance.Include(a => a.AttendanceStatus)
                .Where(a => a.ApplicationUserId == Id && a.PunchDate.Value.Month == int.Parse(SelectedMonth) && a.PunchDate.Value.Year == int.Parse(SelectedYear))
                .OrderBy(a => a.PunchDate).ToListAsync();

            // Get the advance salary from last month
            // If the current month is Jan shift the year backward and change the month to Dec
            if(int.Parse(SelectedMonth) == 1)
            {
                AdvSalaryPur = await _context.StaffSalary.Where(s => s.staffID == Id && s.Month == 12 && s.Year == int.Parse(SelectedYear)-1).SingleOrDefaultAsync();
            }
            else
            {
                AdvSalaryPur = await _context.StaffSalary.Where(s => s.staffID == Id && s.Month == int.Parse(SelectedMonth)-1 && s.Year == int.Parse(SelectedYear)).SingleOrDefaultAsync();
            }

            // initialize a new salary object with staff data default salary info
            StaffSalary = new StaffSalary
            {
                staffID = applicationUser.Id,
                BasicSalary = applicationUser.StaffData.BasicSalary,
                Allowances = applicationUser.StaffData.Allowances,
                EPF = applicationUser.StaffData.EPF,
                SocsoRm = applicationUser.StaffData.SocsoRm,
                EIS = applicationUser.StaffData.EIS,
                Tax = applicationUser.StaffData.Tax,
                EREPF = applicationUser.StaffData.EREPF,
                ERSocsoRm = applicationUser.StaffData.ERSocsoRm,
                EREIS = applicationUser.StaffData.EREIS,
                Socso = applicationUser.StaffData.Socso,
                AdvSalary = AdvSalaryPur != null ? AdvSalaryPur.AdvSalaryPlus : 0,
                Month = int.Parse(SelectedMonth),
                Year = int.Parse(SelectedYear)
            };
            ExtraEarnCount = 5;
            SalaryItem = await _context.SalaryItem.ToListAsync();
            ExtraEarnItems = new List<SelectListItem>();
            ExtraDeductItems = new List<SelectListItem>();
            foreach (var v in SalaryItem)
            {
                if (v.IsDeduction == false)
                {
                    ExtraEarnItems.Add(new SelectListItem(v.Name, v.Id + "," + v.DefaultAmount.ToString()));
                }
                else
                {
                    ExtraDeductItems.Add(new SelectListItem(v.Name, v.Id + "," + v.DefaultAmount.ToString()));
                }
            }
            StaffSalaryExtras = new List<StaffSalaryExtra>
            {
                new StaffSalaryExtra(),
                new StaffSalaryExtra(),
                new StaffSalaryExtra(),
                new StaffSalaryExtra(),
                new StaffSalaryExtra(),
                new StaffSalaryExtra(),
                new StaffSalaryExtra(),
                new StaffSalaryExtra(),
                new StaffSalaryExtra(),
                new StaffSalaryExtra()
            };
            EarnSelect = new List<string>
            {
                "","","","","","","","","",""
            }; 
            DeductSelect = new List<string>
            {
                "","","","",""
            };
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    if (StaffSalaryExtras[i].SalaryItemId == 0)
            //        ModelState.Remove("StaffSalaryExtras[" + i + "].Amount");
            //}
            ModelState.Remove("StaffSalary.staff");
            if (!ModelState.IsValid)
            {
                //applicationUser = await _userManager.FindByIdAsync(Id);
                applicationUser = await _userManager.Users.Include(u => u.StaffData).Where(u => u.Id == StaffSalary.staffID).SingleOrDefaultAsync();

                if (applicationUser == null)
                {
                    return NotFound();
                }
                bool isStaff = await _userManager.IsInRoleAsync(applicationUser, "staff");
                if (!isStaff)
                {
                    return NotFound();
                }

                if (string.IsNullOrEmpty(SelectedYear) || string.IsNullOrEmpty(SelectedMonth))
                {
                    SelectedMonth = DateTime.Now.Month.ToString();
                    SelectedYear = DateTime.Now.Year.ToString();
                }
                SelectedDate = DateTime.Parse(SelectedYear + "-" + SelectedMonth + "-01").ToString("MMMM yyyy");
                // get attendance for this month
                WeekdaysCount = WeekDaysInMonth(StaffSalary.Year, StaffSalary.Month);

                UserAttendance = await _context.Attendance.Include(a => a.AttendanceStatus)
                    .Where(a => a.ApplicationUserId == StaffSalary.staffID && a.PunchDate.Value.Month == int.Parse(SelectedMonth) && a.PunchDate.Value.Year == int.Parse(SelectedYear))
                    .OrderBy(a => a.PunchDate).ToListAsync();

                ExtraEarnCount = 5;
                SalaryItem = await _context.SalaryItem.ToListAsync();
                ExtraEarnItems = new List<SelectListItem>();
                ExtraDeductItems = new List<SelectListItem>();
                foreach (var v in SalaryItem)
                {
                    if (v.IsDeduction == false)
                    {
                        ExtraEarnItems.Add(new SelectListItem(v.Name, v.Id + "," + v.DefaultAmount.ToString()));
                    }
                    else
                    {
                        ExtraDeductItems.Add(new SelectListItem(v.Name, v.Id + "," + v.DefaultAmount.ToString()));
                    }
                }

                return Page();
            }
            StaffSalary.MailNum = 0;
            StaffSalary.DateCreated = DateTime.Now;
            _context.StaffSalary.Add(StaffSalary);
            await _context.SaveChangesAsync();
            foreach (var v in StaffSalaryExtras)
            {
                if (v.SalaryItemId == 0) continue;
                v.StaffSalaryId = StaffSalary.salaryID;
                await _context.StaffSalaryExtra.AddAsync(v);
                await _context.SaveChangesAsync();
            }


            StatusMessage = "Staff Salary Created.";
            return RedirectToPage("./Index", new { SelectedMonth, SelectedYear});
        }
    }
}