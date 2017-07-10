#if Repository_IEntity
namespace Repository.IEntity
#else
namespace Raven.Data.Entity
#endif
{
    /// <summary>
    /// 自增Entity
    /// </summary>
    public interface IAutoIncr
    {
    }

    /// <summary>
    /// 自增Entity
    /// </summary>
    public interface IAutoIncr<T> : IAutoIncr, IEntity<T>
    {
    }
}
