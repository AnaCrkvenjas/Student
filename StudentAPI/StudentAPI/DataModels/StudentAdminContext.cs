using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.DataModels
{
    public class StudentAdminContext:DbContext

    {
        public StudentAdminContext(DbContextOptions<StudentAdminContext> options):base (options)
        {


        }
        public DbSet<Student> Students { get; set; }

        public DbSet<Gender> Genders { get; set; }

        public DbSet<Address> Addresses { get; set; }
        





    }
}
