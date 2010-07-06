using System;
using System.Collections.ObjectModel;

namespace Azzeton.Core.Entity
{
    [Serializable()]
    public class Customer : GenericBase
    {
        /// <summary>
        /// Initialize Customer
        /// </summary>
        public Customer() { }
        /// <summary>
        /// Initialize Customer
        /// </summary>
        /// <param name="id">Id of entity</param>
        public Customer(int id): this()
        {
            this.Id = id;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="firstname"></param>
        /// <param name="surname"></param>
        public Customer(int id, string firstname, string surname):this()
        {
            this.Id = id;
            this.Firstname = firstname;
            this.Surname = surname;
        }
        /// <summary>
        /// Initialize Customer
        /// </summary>
        /// <param name="id">Id of entity</param>
        /// <param name="firstname">Firstname of entity (fistname or contact name)</param>
        /// <param name="surname">Surname of entity (surname or company name)</param>
        /// <param name="stamp">TimeStamp</param>
        public Customer(int id, string firstname, string surname, DateTime stamp):this(id,firstname,surname)
        {
            this.Stamp = stamp;
        }
        /// <summary>
        /// Initialize Customer
        /// </summary>
        /// <param name="id">Id of entity</param>
        /// <param name="firstname">Firstname of entity (fistname or contact name)</param>
        /// <param name="surname">Surname of entity (surname or company name)</param>
        /// <param name="stamp">TimeStamp</param>
        /// <param name="visible">Visibility of entity</param>
        public Customer(int id, string firstname, string surname, DateTime stamp, bool visible): this(id,firstname,surname,stamp)
        {
            this.Visible = visible;
        }
        /// <summary>
        /// Initialize Customer
        /// </summary>
        /// <param name="id">Id of entity</param>
        /// <param name="firstname">Firstname of entity (fistname or contact name)</param>
        /// <param name="surname">Surname of entity (surname or company name)</param>
        /// <param name="stamp">TimeStamp</param>
        /// <param name="visible">Visibility of entity</param>
        /// <param name="tag">Any other data</param>
        public Customer(int id, string firstname, string surname, DateTime stamp, bool visible, object tag): this(id, firstname, surname, stamp, visible)
        {
            this.Tag = tag;
        }
        /// <summary>
        /// Id of Customer or Supplier
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name 1 (First Name of Customer or Contact Name of Supplier)
        /// </summary>
        public string Firstname { get; set; }
        /// <summary>
        /// Surname (Surname Cusomter or Company Name of Supplier))
        /// </summary>
        public string Surname { get; set; }
    }
    public class CustomerManager
    {
    }
}
