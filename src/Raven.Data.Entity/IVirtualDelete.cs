#if Repository_IEntity
namespace Repository.IEntity
#else
namespace Raven.Data.Entity
#endif
{
    /// <summary>
    /// 虚拟删除约束接口
    /// </summary>
    public interface IVirtualDelete
    {
        /// <summary>
        /// 是否虚拟删除
        /// </summary>
        bool IsDel { get; set; }
    }
}
