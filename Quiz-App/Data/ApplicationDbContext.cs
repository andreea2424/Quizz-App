using Microsoft.EntityFrameworkCore;
using Quiz_App.Models;
using System.Collections.Generic;

namespace Quiz_App.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Books> Books { get; set; }

    }


}       
    

