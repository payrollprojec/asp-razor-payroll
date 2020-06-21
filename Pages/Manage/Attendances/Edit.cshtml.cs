using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

namespace PayrollAppRazorPages.Pages.Manage.Attendances
{
    [Authorize(Roles = "superadmin,admin")]
    public class EditModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public EditModel(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        public ApplicationUser applicationUser { get; set; }
        public IList<Attendance> UserAttendance { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SelectedMonth { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SelectedYear { get; set; }
        public string SelectedDate { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
            [Display(Name = "Date")]
            [DataType(DataType.Date)]
            public DateTime PunchDate { get; set; }
            [Required]
            public string Id { get; set; }
        }

        public SelectList AttendanceStatus { get; set; }
        [BindProperty]
        public string SelectedStatus { get; set; }
        public DateTime MaxDate { get; set; }
        [TempData]
        public string StatusMessage { get; set; }
        public async Task<IActionResult> OnGetAsync(string Id)
        {
            applicationUser = await _userManager.FindByIdAsync(Id);

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


            Input = new InputModel()
            {
                Id = applicationUser.Id
            };
            AttendanceStatus = new SelectList(await _context.AttendanceStatus.Select(a => a.Status).ToListAsync());

            UserAttendance = await _context.Attendance.Include(a => a.AttendanceStatus)
                .Where(a => a.ApplicationUserId == Id && a.PunchDate.Value.Month == int.Parse(SelectedMonth) && a.PunchDate.Value.Year == int.Parse(SelectedYear))
                .OrderBy(a => a.PunchDate).ToListAsync();

            if (UserAttendance.Count() != 0 && UserAttendance.Last().PunchDate.HasValue)
                MaxDate = UserAttendance.Last().PunchDate.Value.AddDays(1);

            else
                MaxDate = DateTime.Parse(SelectedYear + "-" + SelectedMonth + "-01");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            applicationUser = await _userManager.FindByIdAsync(Input.Id);

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

            AttendanceStatus = new SelectList(await _context.AttendanceStatus.Select(a => a.Status).ToListAsync());

            UserAttendance = await _context.Attendance.Include(a => a.AttendanceStatus)
                .Where(a => a.ApplicationUserId == Input.Id && a.PunchDate.Value.Month == int.Parse(SelectedMonth) && a.PunchDate.Value.Year == int.Parse(SelectedYear))
                .OrderBy(a => a.PunchDate).ToListAsync();
            if (UserAttendance.Count() != 0 && UserAttendance.Last().PunchDate.HasValue)
                MaxDate = UserAttendance.Last().PunchDate.Value.AddDays(1);
            else
                MaxDate = DateTime.Parse(SelectedYear + "-" + SelectedMonth + "-01");
            if (!ModelState.IsValid)
            {
                return Page();
            }

            int SelectedStatusId = await _context.AttendanceStatus.Where(a => a.Status == SelectedStatus).Select(a => a.Id).SingleOrDefaultAsync();

            var checkAttendance = await _context.Attendance.Where(a => a.ApplicationUserId == Input.Id && a.PunchDate == Input.PunchDate).SingleOrDefaultAsync();
            if (checkAttendance != null)
            {
                ModelState.AddModelError("dup", "Date already recorded");
                return Page();
            }

            var attendance = new Attendance()
            {
                ApplicationUserId = Input.Id,
                PunchDate = Input.PunchDate,
                AttendanceStatusId = SelectedStatusId
            };

            _context.Attendance.Add(attendance);
            await _context.SaveChangesAsync();
            StatusMessage = "Attendance has been added";
            return RedirectToPage("Edit", new { Id = Input.Id, SelectedMonth = Input.PunchDate.Month, SelectedYear = Input.PunchDate.Year });
        }
        [BindProperty]
        public int DeleteId { get; set; }
        public async Task<IActionResult> OnPostDeleteAsync()
        {
            Attendance att = await _context.Attendance.Where(a => a.Id == DeleteId).SingleOrDefaultAsync();
            _context.Attendance.Remove(att);
            await _context.SaveChangesAsync();
            StatusMessage = "Record Deleted.";
            return RedirectToPage("Edit", new { Id = att.ApplicationUserId, SelectedMonth, SelectedYear });
        }
    }
}