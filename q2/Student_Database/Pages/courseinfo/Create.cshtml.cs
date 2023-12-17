using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Student_Database.Data;
using Student_Database.models;

namespace Student_Database.Pages.courseinfo
{
    public class CreateModel : PageModel
    {
        private readonly Student_Database.Data.Student_DatabaseContext _context;

        public CreateModel(Student_Database.Data.Student_DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public course course { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.course == null || course == null)
            {
                return Page();
            }

            _context.course.Add(course);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
