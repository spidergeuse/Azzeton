using System;
using System.Collections.Generic;
using System.Text;

namespace Azzeton.Core.Entity
{
    /// <summary>
    /// Schedule for costing product
    /// </summary>
    public class PriceScheduleProduct
    {
        /// <summary>
        /// Id of schedule
        /// </summary>
        public int ScheduleID { get; set; }
        /// <summary>
        /// Id of product
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Price of product
        /// </summary>
        public decimal ProductPrice { get; set; }
    }
}
