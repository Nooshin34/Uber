using System;
using System.Collections.Generic;
using System.Text;

namespace Uber.Domain.Contracts
{
    public interface ICreatableEntity
    {
        public DateTime CreatedAt { get; set; }
    }
}
