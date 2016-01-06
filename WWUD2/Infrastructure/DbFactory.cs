using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WWUD2.DAL;

namespace WWUD2.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        MainDBContext dbContext;

        public MainDBContext Init()
        {
            return dbContext ?? (dbContext = new MainDBContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}