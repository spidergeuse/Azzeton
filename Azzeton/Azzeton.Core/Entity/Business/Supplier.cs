using System;
using System.Collections.ObjectModel;

namespace Azzeton.Core.Entity
{
    [Serializable()]
    public class Supplier : GenericBase
    {
        /// <summary>
        /// Initialize Supplier
        /// </summary>
        public Supplier() { }
        /// <summary>
        /// Initialize Supplier
        /// </summary>
        /// <param name="id">Id of entity</param>
        public Supplier(int id)
            : this()
        {
            this.Id = id;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="companyname"></param>
        /// <param name="contactperson"></param>
        public Supplier(int id, string companyname, string contactperson)
            : this()
        {
            this.Id = id;
            this.CompanyName = companyname;
            this.ContactPerson = contactperson;
        }
        /// <summary>
        /// Initialize Supplier
        /// </summary>
        /// <param name="id">Id of entity</param>
        /// <param name="companyname">Firstname of entity (fistname or contact name)</param>
        /// <param name="contactperson">Surname of entity (contactperson or company name)</param>
        /// <param name="stamp">TimeStamp</param>
        public Supplier(int id, string companyname, string contactperson, DateTime stamp)
            : this(id, companyname, contactperson)
        {
            this.Stamp = stamp;
        }
        /// <summary>
        /// Initialize Supplier
        /// </summary>
        /// <param name="id">Id of entity</param>
        /// <param name="companyname">Firstname of entity (fistname or contact name)</param>
        /// <param name="contactperson">Surname of entity (contactperson or company name)</param>
        /// <param name="stamp">TimeStamp</param>
        /// <param name="visible">Visibility of entity</param>
        public Supplier(int id, string companyname, string contactperson, DateTime stamp, bool visible)
            : this(id, companyname, contactperson, stamp)
        {
            this.Visible = visible;
        }
        /// <summary>
        /// Initialize Supplier
        /// </summary>
        /// <param name="id">Id of entity</param>
        /// <param name="companyname">Firstname of entity (fistname or contact name)</param>
        /// <param name="contactperson">Surname of entity (contactperson or company name)</param>
        /// <param name="stamp">TimeStamp</param>
        /// <param name="visible">Visibility of entity</param>
        /// <param name="tag">Any other data</param>
        public Supplier(int id, string companyname, string contactperson, DateTime stamp, bool visible, object tag)
            : this(id, companyname, contactperson, stamp, visible)
        {
            this.Tag = tag;
        }
        /// <summary>
        /// Id of Supplier or Supplier
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name 1 (First Name of Supplier or Contact Name of Supplier)
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// Surname (Surname Cusomter or Company Name of Supplier))
        /// </summary>
        public string ContactPerson { get; set; }
    }
    public class SupplierManager
    {
    }
}
