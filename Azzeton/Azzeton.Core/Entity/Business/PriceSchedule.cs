using System;
using System.Collections.Generic;
using System.Text;

namespace Azzeton.Core.Entity
{
    /// <summary>
    /// Object to create various cost schedules
    /// </summary>
    public class PriceSchedule : GenericBase
    {
        /// <summary>
        /// Id of schedule
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of schedule
        /// </summary>
        public string Schedule { get; set; }
    }
}
