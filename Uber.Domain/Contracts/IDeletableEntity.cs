using System;
using System.Collections.Generic;
using System.Text;

namespace Uber.Domain.Contracts
{
    public interface IDeletableEntity
    {
        public bool IsDeleted { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
