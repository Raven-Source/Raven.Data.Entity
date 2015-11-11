using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.IEntity
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
