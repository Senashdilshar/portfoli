using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Student_Database.models;

namespace Student_Database.Data
{
    public class Student_DatabaseContext : DbContext
    {
        public Student_DatabaseContext (DbContextOptions<Student_DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Student_Database.models.Student> Student { get; set; } = default!;

        public DbSet<Student_Database.models.course>? course { get; set; }
    }
}
