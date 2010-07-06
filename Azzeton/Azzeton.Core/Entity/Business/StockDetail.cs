using System;
using System.Collections.ObjectModel;
using System.Text;

namespace Azzeton.Core.Entity
{
    /// <summary>
    /// Details of an stock
    /// </summary>
    [Serializable()]
    public class StockDetail : GenericBase
    {
        /// <summary>
        /// Id of stock item
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Id of stock
        /// </summary>
        public int StockId { get; set; }
        /// <summary>
        /// Id of product
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Product discontinued or not
        /// </summary>
        public bool Discontinued { get; set; }
        /// <summary>
        /// Re-Order Level
        /// </summary>
        public int ReorderLevel { get; set; }
        /// <summary>
        /// Quantity of product in stock
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// Cost of product
        /// </summary>
        public decimal CostPrice { get; set; }
        /// <summary>
        /// Expected profit margin on sale relative to CostPrice (-ve for loss / reduction)
        /// </summary>
        public decimal ProfitMargin { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
    public class StockDetailManager
    {
    }
}
