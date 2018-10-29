using DevFramework.Core.Entities;
using System.Data.Entity;
using System.Linq;

namespace DevFramework.Core.DataAccess.EntityFramework
{
    public class EfQuearyableRepository<T>:IQueryableRepository<T> where T:class ,IEntity,new()
    {
        private DbContext _context;
        private IDbSet<T> _entities;
        public EfQuearyableRepository(DbContext context)
        {
            _context = context;
        }
        public IQueryable<T> Table => this.Entities;

        protected virtual IDbSet<T> Entities
        {
            get { return _entities ?? (_entities = _context.Set<T>()); }
        }
    }
}
