#if Repository_IEntity
namespace Repository.IEntity
{
    /// <summary>
    /// 虚拟删除约束接口
    /// </summary>
    [System.Obsolete("请使用IDelible")]
    public interface IVirtualDelete
    {
        /// <summary>
        /// 是否虚拟删除
        /// </summary>
        bool IsDel { get; set; }
    }
}
#endif

