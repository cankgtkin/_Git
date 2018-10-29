using DevFramework.Core.Entities;
using System.Linq;

namespace DevFramework.Core.DataAccess.NHibernate
{
    public class NhQueryableRepository<T>:IQueryableRepository<T> where T:class, IEntity,new()
    {
        private NHibernateHelper _nHibernateHelper;
        private IQueryable<T> _entities;
        public NhQueryableRepository(NHibernateHelper nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }
        public IQueryable<T> Table => this.Entities;
        //{
        //    get { return this._entities; }
        //}
        public virtual IQueryable<T> Entities
        {
            get { return _entities ?? (_entities = _nHibernateHelper.OpenSession().Query<T>()); }
            //{
            //    if(_entities == null)
            //    {
            //        _entities = _nHibernateHelper.OpenSession().Query<T>();
            //    }
            //    return _entities;
            //}
        }   
    }
}
