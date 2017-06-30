#if Repository_IEntity
namespace Repository.IEntity
#else
namespace Raven.Repository.IEntity
#endif
{
    /// <summary>
    /// Entity
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public interface IEntity<TKey>
    {
        /// <summary>
        /// 主键
        /// </summary>
        TKey ID { get; set; }
    }
}
