using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.Data.Entity
{
    /// <summary>
    /// 虚拟删除约束接口
    /// </summary>
    public interface IDelible
    {
        /// <summary>
        /// 是否虚拟删除
        /// </summary>
        bool Del { get; set; }
    }
}
