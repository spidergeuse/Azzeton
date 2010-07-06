using System;
using System.Collections.ObjectModel;
using System.Text;

namespace Azzeton.Core.Entity
{
    /// <summary>
    /// Represents a transaction transaction
    /// </summary>
    [Serializable()]
    public abstract class Transaction : GenericBase
    {
        /// <summary>
        /// Id of transaction
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Id of customer
        /// </summary>
        public int OwnerID { get; set; }
        /// <summary>
        /// Date of transaction
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Id of user
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        public Transaction() { }
        public Transaction(int id, int owner, DateTime date)
        {
            this.Id = id;
            this.OwnerID = owner;
            this.Date = date;
        }
        public Transaction(int id, int owner, DateTime date, bool visible)
            : this(id, owner, date)
        {
            this.Visible = visible;
        }
        public Transaction(int id, int owner, DateTime date, bool visible, object tag)
            : this(id, owner, date, visible)
        {
            this.Tag = tag;
        }
    }

}
