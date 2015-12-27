﻿using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WWUD2.DAV
{
    public partial class MainDBContext : DbContext
    { 
        
        public MainDBContext()
            : base("name=MainDBContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Models.Question> Questions { get; set; }



    }
}