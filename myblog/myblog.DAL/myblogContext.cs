using myblog.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myblog.DAL
{
    public class myblogContext : DbContext
    {
        public DbSet<User> myblogUsers { get; set; }
        public DbSet<Note> Notes { get; set; }        
        public DbSet<Category> Categories { get; set; }
        
        public myblogContext()
        {
            Database.SetInitializer(new MyIntializer()); 
        }
    }
}
