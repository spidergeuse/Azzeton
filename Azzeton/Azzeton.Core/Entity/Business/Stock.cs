using System;
using System.Collections.ObjectModel;
using System.Text;

namespace Azzeton.Core.Entity
{
    /// <summary>
    /// Represents a Stock
    /// </summary>
    [Serializable()]
    public class Stock : GenericBase
    {
        /// <summary>
        /// Enumeration of status of stock
        /// </summary>
        public enum StockStatus
        {
            Finished,
            Canceled
        }
        /// <summary>
        /// Id of stock
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Id of owner of stock 
        /// </summary>
        public int OwnerID { get; set; }
        /// <summary>
        /// Date of stock
        /// </summary>
        public DateTime StockDate { get; set; }
        /// <summary>
        /// Status of stock
        /// </summary>
        public StockStatus Status { get; set; }
    }

    public class StockManager
    {
    }
}
