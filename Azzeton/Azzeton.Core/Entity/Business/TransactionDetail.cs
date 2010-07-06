using System;
using System.Collections.ObjectModel;
using System.Text;

namespace Azzeton.Core.Entity
{
    /// <summary>
    /// Details of an Transaction
    /// </summary>
    [Serializable()]
    public abstract class TransactionDetail
    {
        /// <summary>
        /// Id of Transaction item
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Parent Transaction object
        /// </summary>
        public Transaction Transaction { get; set; }
        /// <summary>
        /// Parent product object
        /// </summary>
        public Product Product { get; set; }
        /// <summary>
        /// Cost
        /// </summary>
        public decimal Cost { get; set; }
    }
}
