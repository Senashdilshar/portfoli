﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student_Database.Data;
using Student_Database.models;

namespace Student_Database.Pages.studentinfo
{
    public class IndexModel : PageModel
    {
        private readonly Student_Database.Data.Student_DatabaseContext _context;

        public IndexModel(Student_Database.Data.Student_DatabaseContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Student != null)
            {
                Student = await _context.Student.ToListAsync();
            }
        }
    }
}
