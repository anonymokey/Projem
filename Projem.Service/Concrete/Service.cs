using Projem.Data;
using Projem.Data.Concrete;
using Projem.Entities;
using Projem.Service.Abstract;

namespace Projem.Service.Concrete
{
    public class Service<T> : Repository<T>, IService<T> where T : class, IEntity, new()
    {
        public Service(DataBaseContext context) : base(context)
        {
        }
    }
}