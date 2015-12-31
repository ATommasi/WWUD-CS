using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WWUD2.DAV
{
    public partial class MainDBContext : WWUD2.Models.ApplicationDbContext
    { 
        
        public MainDBContext()
            //: base("name=MainDBContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Models.Question> Questions { get; set; }
        public virtual DbSet<Models.Answer> Answers { get; set; }

        //public virtual DbSet<Models.ApplicationUser> ApplicationUsers { get; set; }
    }
}