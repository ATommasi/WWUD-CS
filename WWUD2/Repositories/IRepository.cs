using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WUDIF.Repositories
{
    // The Generic Interface Repository for performing read/add/delete operations
    public interface IRepository<TEnt, in TPk> where TEnt :class

    {
        IEnumerable<TEnt> Get();
        TEnt Get(TPk id);
        void Add(TEnt entity);
        void Remove(TEnt entity);
        void Remove(int id);
    }
}
