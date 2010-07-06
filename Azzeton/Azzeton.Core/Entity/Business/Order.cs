using System;
using System.Collections.ObjectModel;
using System.Text;

namespace Azzeton.Core.Entity
{
    /// <summary>
    /// Represents an abstract Order
    /// </summary>
    [Serializable()]
    public abstract class Order:GenericBase
    {
        /// <summary>
        /// Enumeration of status of Order
        /// </summary>
        public enum OrderStatus
        {
            Delivered,
            NotDelivered,
            Canceled
        }
        /// <summary>
        /// Id of Order
        /// </summary>
        public virtual int Id { get; set; }
        /// <summary>
        /// Id of owner of Order 
        /// </summary>
        public virtual int OwnerID {get;set;}
        /// <summary>
        /// Date of Order
        /// </summary>
        public virtual DateTime OrderDate  { get; set; }
        /// <summary>
        /// Date of deliver
        /// </summary>
        public virtual DateTime DeliveryDate  { get; set; }
        /// <summary>
        /// Status of Order
        /// </summary>
        public virtual OrderStatus Status {get; set;}
        /// <summary>
        /// Commend on order
        /// </summary>
        public virtual string Comment { get; set; }
    }
}
