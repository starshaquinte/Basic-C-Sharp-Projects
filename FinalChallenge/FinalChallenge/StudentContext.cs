using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalChallenge
{
    public class StudentContext : DbContext
    {
        //public DbSet<Student> Blogs { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
