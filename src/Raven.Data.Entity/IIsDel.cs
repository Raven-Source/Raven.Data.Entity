#if Repository_IEntity
namespace Repository.IEntity
#else
namespace Raven.Data.Entity
#endif
{
    /// <summary>
    /// 逻辑删除约束接口
    /// </summary>
    public interface IIsDelete
    {
        /// <summary>
        /// 是否逻辑删除
        /// </summary>
        bool IsDel { get; set; }
    }
}
