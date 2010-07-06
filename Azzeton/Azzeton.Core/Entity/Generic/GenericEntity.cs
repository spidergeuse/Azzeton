using System;
using System.Collections.ObjectModel;
using System.Text;

namespace Azzeton.Core.Entity
{
    /// <summary>
    /// Represent a generic entity (customer or supplier base)
    /// </summary>
    [Serializable()]
    public class GenericEntity :GenericBase
    {
        /// <summary>
        /// Initialize GenericEntity
        /// </summary>
        public GenericEntity() { }
        /// <summary>
        /// Initialize GenericEntity
        /// </summary>
        /// <param name="id">Id of entity</param>
        public GenericEntity(int id): this()
        {
            this.Id = id;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name1"></param>
        /// <param name="name2"></param>
        public GenericEntity(int id, string name1, string name2):this()
        {
            this.Id = id;
            this.Name1 = name1;
            this.Name2 = name2;
        }
        /// <summary>
        /// Initialize GenericEntity
        /// </summary>
        /// <param name="id">Id of entity</param>
        /// <param name="name1">Name1 of entity (fistname or contact name)</param>
        /// <param name="name2">Name2 of entity (name2 or company name)</param>
        /// <param name="stamp">TimeStamp</param>
        public GenericEntity(int id, string name1, string name2, DateTime stamp):this(id,name1,name2)
        {
            this.Stamp = stamp;
        }
        /// <summary>
        /// Initialize GenericEntity
        /// </summary>
        /// <param name="id">Id of entity</param>
        /// <param name="name1">Name1 of entity (fistname or contact name)</param>
        /// <param name="name2">Name2 of entity (name2 or company name)</param>
        /// <param name="stamp">TimeStamp</param>
        /// <param name="visible">Visibility of entity</param>
        public GenericEntity(int id, string name1, string name2, DateTime stamp, bool visible): this(id,name1,name2,stamp)
        {
            this.Visible = visible;
        }
        /// <summary>
        /// Initialize GenericEntity
        /// </summary>
        /// <param name="id">Id of entity</param>
        /// <param name="name1">Name1 of entity (fistname or contact name)</param>
        /// <param name="name2">Name2 of entity (name2 or company name)</param>
        /// <param name="stamp">TimeStamp</param>
        /// <param name="visible">Visibility of entity</param>
        /// <param name="tag">Any other data</param>
        public GenericEntity(int id, string name1, string name2, DateTime stamp, bool visible, object tag): this(id, name1, name2, stamp, visible)
        {
            this.Tag = tag;
        }
        /// <summary>
        /// Id of GenericEntity or Supplier
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name 1 (First Name of GenericEntity or Contact Name of Supplier)
        /// </summary>
        public string Name1 { get; set; }
        /// <summary>
        /// Name2 (Surname Cusomter or Company Name of Supplier))
        /// </summary>
        public string Name2 { get; set; }
    }
}
