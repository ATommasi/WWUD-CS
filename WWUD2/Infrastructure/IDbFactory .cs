using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WWUD2.DAL;

namespace WWUD2.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        MainDBContext Init();
    }
}
