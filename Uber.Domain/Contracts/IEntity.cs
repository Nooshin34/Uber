using System;
using System.Collections.Generic;
using System.Text;

namespace Uber.Domain.Contracts
{
    public interface IEntity<T>
    {
        public T Id { get; set; }
        
    }
}
