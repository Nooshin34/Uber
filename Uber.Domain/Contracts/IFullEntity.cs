using System;
using System.Collections.Generic;
using System.Text;

namespace Uber.Domain.Contracts
{
    public interface IFullEntity<T> : IEntity<T> , ICreatableEntity , IDeletableEntity
    {
    }
}
