using System;
using System.Collections.ObjectModel;
using System.Text;

namespace Azzeton.Core.Entity
{
    /// <summary>
    /// Details of an abstract OrderDetail class
    /// </summary>
    [Serializable()]
    public abstract class OrderDetail : GenericBase
    {
        /// <summary>
        /// Id of order detail item
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// OrderId of order detail item
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// ProductId of order detail item
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Quantity of order detail item
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// Unit Cost of order detail item
        /// </summary>
        public decimal UnitCost { get; set; }
    }
}
