using System;
using System.Collections.Generic;
using System.Text;

namespace Azzeton.Core.Entity
{
    public abstract class Discount
    {
        public virtual decimal Amount { get; set; }
        public virtual int ProductId { get; set; }
    }
}
