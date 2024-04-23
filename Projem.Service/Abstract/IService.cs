using Projem.Data.Abstract;
using Projem.Entities;

namespace Projem.Service.Abstract
{
    public interface IService<T> : IRepository<T> where T : class, IEntity, new()
    {
        
    }
}
